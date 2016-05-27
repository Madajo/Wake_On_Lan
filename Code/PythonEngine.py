#Region -- Imports
from RemoteDesktop import *
from WakeUp import *
from Shutdown import *
from DB_Managment import *
from Scheduler import *
import socket
import time
#EndRegion -- Imports
import threading
#Region - Consts
GUI_PORT = 9000

#EndRegion

class GUI(threading.Thread):
    state_machine = {}

    def __init__(self):
        #Region -- State Machine
        self.state_machine["WakeUpComp"] = self.WakeUpComp
        self.state_machine["WakeUpAll"] = self.WakeUpAll
        self.state_machine["ShutDownComp"] = self.ShutDownComp
        self.state_machine["ShutDownAll"] = self.ShutDownAll
        self.state_machine["RemoteDesktop"] = self.RemoteDesktop
        self.state_machine["GetDB"] = self.GetDB
        self.state_machine["UpdateDB"] = self.UpdateDB
        self.state_machine["GetSchedule"] = self.GetSchedule
        self.state_machine["AddSchedule"] = self.AddSchedule
        self.state_machine["RemoveFromSchedule"] = self.RemoveFromSchedule
        self.state_machine["ClearSchedule"] = self.ClearSchedule
        #EndRegion -- State Machine

        self.GuiSock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)  # socket between Python and C#
        threading.Thread.__init__(self)
        while True:
            try:
                self.GuiSock.connect(('127.0.0.1', GUI_PORT))
                break
            except socket.error:
                continue


    def Run(self):
        while True:
            data = self.GuiSock.recv(1024)
            if len(data) > 0:
                command = data.split('#')
                if command[0] == "WakeUpComp":
                    self.state_machine["WakeUpComp"](command[1],command[2])
                if command[0] == "WakeUpAll":
                    self.state_machine["WakeUpAll"]()
                if command[0] == "ShutDownComp":
                    self.state_machine["ShutDownComp"](command[1],command[2],command[3],command[4],command[5])
                if command[0] == "ShutDownAll":
                    self.state_machine["ShutDownAll"](command[1],command[2],command[3],command[4])
                if command[0] == "RemoteDesktop":
                    self.state_machine["RemoteDesktop"](command[1])
                if command[0] == "GetDB":
                    self.state_machine["GetDB"]()
                if command[0] == "UpdateDB":
                    self.state_machine["UpdateDB"]()
                if command[0] == "GetSchedule":
                    self.state_machine["GetSchedule"]()
                if command[0] == "AddSchedule":
                    self.state_machine["AddSchedule"](command[1],command[2],command[3],command[4],command[5])
                if command[0] == "RemoveFromSchedule":
                    self.state_machine["RemoveFromSchedule"](command[1],command[2],command[3],command[4],command[5])
                if command[0] == "ClearSchedule":
                    self.state_machine["ClearSchedule"]()



    def WakeUpComp(self,ip,mac):
        try:
            WakeUp(mac).Run()
            DB_Manage().ChangeToOnline(ip,mac)
            self.GuiSock.send("WakeUpStatus#Computer Awakening!")
        except:
            self.GuiSock.send("WakeUpStatus#Error Occurred while Waking Up Computer")
        time.sleep(1)

    def WakeUpAll(self):
        dblist = DB_Manage().RetreiveDatabase()
        error = False
        if len(dblist) > 0:
            for i in range(0,len(dblist)-1):
                if dblist[i][3] != 'Online':
                    try:
                        WakeUp(dblist[i][2]).Run()
                        DB_Manage().ChangeToOnline(dblist[i][1],dblist[i][2])
                    except:
                        error = True

        if error is False:
            self.GuiSock.send("WakeUpStatus#All Computers are Awake!")
        else:
            self.GuiSock.send("WakeUpStatus#Errors Occurred With Some of the Computers")
        time.sleep(1)

    def ShutDownComp(self,ip,msg,timeout,force,reboot):
        user = 'admin'
        password = ''
        try:
            Shutdown(ip,user,password,msg,int(timeout),int(force),int(reboot)).run()
            DB_Manage().ChangeToOffline(ip)
            self.GuiSock.send("ShutDownStatus#Compter Shutting down.. ")
        except:
            self.GuiSock.send("ShutDownStatus#Error Occurred with Shutting down Computer .. Try Again Later")
        time.sleep(1)

    def ShutDownAll(self,msg,timeout,force,reboot):
        user = 'admin'
        password = ''
        error = False
        dblist = DB_Manage().RetreiveDatabase()
        if len(dblist) > 0:
            for i in range(0,len(dblist)-1):
                try:
                    Shutdown(dblist[i][1],user,password,msg,int(timeout),int(force),int(reboot)).run()
                    DB_Manage().ChangeToOffline(dblist[i][1])
                except:
                    error = True
        if error is False:
            self.GuiSock.send("ShutDownStatus#All Computers Shutting down.. ")
        else:
            self.GuiSock.send("ShutDownStatus#Error Occurred with some of Computers Shutting down.. ")

    def RemoteDesktop(self,ip):
        try:
            RemoteDesktop(ip).Run()
            self.GuiSock.send("RemoteDesktopStatus#Takeing Over Computer..")
        except:
            self.GuiSock.send("RemoteDesktopStatus#Error Occurred while Takeing Over Computer.. Check Remote Dekstop is Allowed on Computer ")

    def GetDB(self):
        if DB_Manage().CheckIfTableExsits() is False:
            self.GuiSock.send("DBStatus#Creating DataBase.. Scaning Network")
            DB_Manage().CreateDatabase()
            print("Creating DB")
        else:
            self.GuiSock.send("DBStatus#Grabing DataBase")

        dblist = DB_Manage().RetreiveDatabase()
        mes = "DataBase#"
        if len(dblist) > 0:
            for i in range(0,len(dblist)-1):
                mes += dblist[i][0] + "&" + dblist[i][1] + "&" + dblist[i][2] + "&" + dblist[i][3] + "@"

            self.GuiSock.send(mes)
            time.sleep(0.5)
            self.GuiSock.send("DBStatus#End Grabing DataBase")
            time.sleep(1)

    def UpdateDB(self):
        self.GuiSock.send("DBStatus#Updating DataBase")
        DB_Manage().UpdateDatabase()
        dblist = DB_Manage().RetreiveDatabase()
        mes = "DataBase#"
        if len(dblist) > 0:
            for i in range(0,len(dblist)-1):
                mes += dblist[i][0] + "&" + dblist[i][1] + "&" + dblist[i][2] + "&" + dblist[i][3] + "@"

            self.GuiSock.send(mes)
            time.sleep(0.5)
            self.GuiSock.send("DBStatus#End Grabing DataBase")
            time.sleep(1)

    def GetSchedule(self):
        if Schudler().CheckIfTableExsits() is False:
            self.GuiSock.send("ScheduleStatus#Schedule is empty")
        else:
            self.GuiSock.send("ScheduleStatus#Grabing Schedule..")
            tasklist = Schudler().RetreiveTasks()
            mes = "Schedule#"
            for i in range(0,len(tasklist)-1):
                mes += tasklist[i][0] + "&" + tasklist[i][1] + "&" + tasklist[i][2] + "&" + tasklist[i][3] + "&" + tasklist[i][4] + "@"

            self.GuiSock.send(mes)
            time.sleep(0.5)
            self.GuiSock.send("ScheduleStatus#End Grabing Schedule")
            time.sleep(1)

    def AddSchedule(self,functype,comp,timer,day,date):
        task = (functype,comp,timer,day,date)
        Schudler().AddTask(task)
        self.GuiSock.send("ScheduleStatus#Schedule Added")

    def RemoveFromSchedule(self,functype,comp,timer,day,date):
        task = (functype,comp,timer,day,date)
        Schudler().RemoveTask(task)
        self.GuiSock.send("ScheduleStatus#Schedule Removed")

    def ClerSchedule(self):
        Schudler().ClearTasks()
        self.GuiSock.send("ScheduleStatus#Schedule DataBase Cleared")












