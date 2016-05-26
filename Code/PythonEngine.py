#Region -- Imports
import Arpscan
import RemoteDesktop
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
        self.DB = DB_Manage()
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
                    self.state_machine["ShutDownAll"](command[1],command[2],command[3],command[4],command[5])
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
        for i in range(0,len(dblist)-1):
            if dblist[i][3] != 'Online':
                try:
                    WakeUp(dblist[i][2]).Run()
                    DB_Manage().ChangeToOnline(dblist[i][1],dblist[i][2])
                except:
                    error = True

        if error == False:
            self.GuiSock.send("WakeUpStatus#All Computers are Awake!")
        else:
            self.GuiSock.send("WakeUpStatus#Errors Occurred With Some of the Computers")
        time.sleep(1)

        





