#Region -- Imports
import sqlite3
import Arpscan
import CIDR
import Ping
import time
#EndRegion -- Imports

#Region -- Const
CONST_DB = "CompList.DB"
CONST_TABLE = "CompTable"
#EndRegion -- Const
class DB_Manage():

    def __init__(self):
        pass

    def CreateDatabase(self):
        #WMI = CIDR.Network()            """--Use WMI Only when not in HADASH School--"""
        #GateWay = WMI.GetFinGateWay()
        #ComplistTemp = Arpscan.Arpscan(Gateway).Scan()
        ComplistTemp = Arpscan.Arpscan("10.92.5.99/24").Scan()
        Complist = list(set(ComplistTemp))
        con = sqlite3.connect(CONST_DB) #Creating Database
        with con:

            cur = con.cursor()
            cur.execute("DROP TABLE IF EXISTS " + CONST_TABLE)
            cur.execute("CREATE TABLE " + CONST_TABLE + "(ID INTEGER PRIMARY KEY AUTOINCREMENT, IP TEXT, MAC TEXT, STATUS TEXT)")
            i=0
            #--------Entering Data---------------
            while i<len(Complist):
                ip = Complist[i].split("-")[0] #Get Comp IP
                mac = Complist[i].split("-")[1] # Get Comp MAC
                i += 1
                #time.sleep(1)
                cur.execute("INSERT INTO " + CONST_TABLE +"(IP, MAC, STATUS) VALUES(?,?,?)",(ip, mac, "Online"))

    def UpdateDatabase(self):
        dblist = self.RetreiveDatabase()
        # WMI = CIDR.Network()            """--Use WMI Only when not in HADASH School--"""
        # GateWay = WMI.GetFinGateWay()
        # ComplistTemp = Arpscan.Arpscan(Gateway).Scan()
        ComplistTemp = Arpscan.Arpscan("10.92.5.99/24").Scan()
        Complist = list(set(ComplistTemp))
        con = sqlite3.connect(CONST_DB)  # Creating Database
        with con:
            cur = con.cursor()
            cur.execute("UPDATE " + CONST_TABLE + "SET STATUS = Offline WHERE STATUS = Online")
            for i in Complist:
                found = False
                for j in dblist:

                    if dblist[j][1] == Complist[i].split("-")[0] and dblist[j][2] == Complist[i].split("-")[1]:
                        cur.execute("UPDATE " + CONST_TABLE + "SET STATUS = Online WHERE IP = ? AND MAC = ?", (dblist[i][1],dblist[i][2]))
                        found = True
                if not found:
                    ip = Complist[i].split("-")[0]
                    mac = Complist[i].split("-")[1]
                    cur.execute("INSERT INTO " + CONST_TABLE + "(IP, MAC, STATUS) VALUES(?,?,?",(ip, mac, "Online"))






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




if __name__ == "__main__":
    x = DB_Manage()
    #x.CreateDatabase()
    x.RetreiveDatabase()