#Region -- Imports
import sqlite3
import Arpscan
import CIDR
import Ping
import time
#EndRegion -- Imports
CONST_DB = "CompList.DB"
CONST_TABLE = "CompTable"
class DB_Manage():

    def __init__(self):
        pass

    def CreateDatabase(self):
        #WMI = CIDR.Network()
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
                ip = Complist[i].split("-")[0]
                mac = Complist[i].split("-")[1]
                status = Ping.Ping(ip).Run() #Geting Computer Status
                time.sleep(0.5)
                i += 1
                #time.sleep(1)
                cur.execute("INSERT INTO " + CONST_TABLE +"(IP, MAC, STATUS) VALUES(?,?,?)",(ip, mac, status))
            con.commit()
            con = sqlite3.connect(CONST_DB)
            cur = con.cursor()
            for j in cur.execute("SELECT * FROM " + CONST_TABLE):
                print j


if __name__ == "__main__":
    x = DB_Manage().CreateDatabase()