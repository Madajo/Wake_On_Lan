#Region -- Imports
import sqlite3
import Arpscan
import CIDR
import Ping
import socket
#EndRegion -- Imports

#Region -- Const
CONST_DB = "CompList.DB"
CONST_TABLE = "CompTable"
#EndRegion -- Const
class DB_Manage():

    def __init__(self):
        pass

    def CreateDatabase(self):
        WMI = CIDR.Network()            #----Use WMI Only when not in HADASH School----
        GateWay = WMI.GetFinGateWay()
        ComplistTemp = Arpscan.Arpscan(GateWay).Scan()
        #ComplistTemp = Arpscan.Arpscan("10.92.5.99/24").Scan()   #----Use Only in HADASH School----
        Complist = list(set(ComplistTemp))
        self.CorrectList(Complist)
        con = sqlite3.connect(CONST_DB) #Creating Database
        with con:

            cur = con.cursor()
            cur.execute("DROP TABLE IF EXISTS " + CONST_TABLE)
            cur.execute("CREATE TABLE " + CONST_TABLE + " (IP TEXT, MAC TEXT, STATUS TEXT)")
            i=0
            #--------Entering Data---------------
            while i<len(Complist):
                ip = Complist[i].split("-")[0] #Get Comp IP
                mac = Complist[i].split("-")[1] # Get Comp MAC
                i += 1
                #time.sleep(1)
                cur.execute("INSERT INTO " + CONST_TABLE +" (IP, MAC, STATUS) VALUES(?,?,?)",(ip, mac, "Online"))

    def UpdateDatabase(self):
        dblist = self.RetreiveDatabase()
        WMI = CIDR.Network()            #----Use WMI Only when not in HADASH School----
        GateWay = WMI.GetFinGateWay()
        ComplistTemp = Arpscan.Arpscan(GateWay).Scan()
        #ComplistTemp = Arpscan.Arpscan("10.92.5.99/24").Scan()  #----Use Only in HADASH School----
        Complist = list(set(ComplistTemp))
        self.CorrectList(Complist)
        con = sqlite3.connect(CONST_DB)  # Creating Database
        with con:
            cur = con.cursor()
            cur.execute("UPDATE " + CONST_TABLE + " SET STATUS = 'Offline' WHERE STATUS = 'Online'")
            for i in range(0,len(Complist)-1):
                ip = Complist[i].split("-")[0]
                mac = Complist[i].split("-")[1]
                found = False
                for j in range(0,len(dblist)-1):

                    if dblist[j][1] == ip and dblist[j][2] == mac:
                        cur.execute("UPDATE " + CONST_TABLE + " SET STATUS = 'Online' WHERE IP = ? AND MAC = ?", (ip, mac))
                        found = True
                    if dblist[j][1] != ip and dblist[j][2] == mac:
                        cur.execute("UPDATE " + CONST_TABLE + " SET IP = ? WHERE MAC = ?", (ip, mac))
                        cur.execute("UPDATE " + CONST_TABLE + " SET STATUS = 'Online' WHERE IP = ? AND MAC = ?", (ip, mac))
                        found = True
                if not found:
                    cur.execute("INSERT INTO " + CONST_TABLE + " (IP, MAC, STATUS) VALUES(?,?,?)",(ip, mac, "Online"))


    def CorrectList(self,CompList):
        my_ip = socket.gethostbyname(socket.gethostname())
        index = -1
        for i in range(0,len(CompList)):
            if CompList[i].split("-")[0] == my_ip:
                index = i
        if index != -1:
            del CompList[index]



    def RetreiveDatabase(self):
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            cur.execute("SELECT * FROM " + CONST_TABLE)
            conlist = cur.fetchall()

        return conlist

    def CheckIfTableExsits(self):
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            try:
                cur.execute("SELECT * FROM " + CONST_TABLE)
                cur.close()
                return True
            except:
                return False

    def ChangeToOnline(self,ip,mac):
        dblist = self.RetreiveDatabase()
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            for i in range(0,len(dblist)):
                if dblist[i][1] == ip and dblist[i][2] == mac:
                    cur.execute("UPDATE " + CONST_TABLE + " SET STATUS = 'Online' WHERE IP = ? AND MAC = ?", (ip, mac))

    def ChangeToOffline(self,ip):
        dblist = self.RetreiveDatabase()
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            for i in range(0,len(dblist)):
                if dblist[i][1] == ip :
                    cur.execute("UPDATE " + CONST_TABLE + " SET STATUS = 'Offline' WHERE IP = ?", (ip))




if __name__ == "__main__":
    x = DB_Manage()
    x.CreateDatabase()
    #x.UpdateDatabase()
    #x.ChangeToOffline('10.0.0.138','e8:fc:af:9b:4c:96')
    pp = x.RetreiveDatabase()
    for i in pp:
        print i