#Region -- Imports
import sqlite3
import time
#EndRegion -- Imports

#Region -- Const
CONST_DB = "CompList.DB"
CONST_TABLE = "TimeTable"
#EndRegion -- Const

class Schudler():

    def __init__(self):
        pass

    def ClearTasks(self):
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            cur.execute("DROP TABLE IF EXISTS " + CONST_TABLE)
            cur.execute("CREATE TABLE " + CONST_TABLE + " (FUNCTYPE TEXT, COMP TEXT, TIME TIME, DAY INT, DATE DATEIME)")


    def AddTask(self,task):
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            cur.execute("INSERT INTO " + CONST_TABLE + "(FUNCTYPE, COMP, TIME, DAY, DATE) " + "VALUES(?,?,?,?,?)", task )

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

    def RetreiveTasks(self):
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            cur.execute("SELECT * FROM " + CONST_TABLE)
            conlist = cur.fetchall()

        return conlist

    def RemoveTask(self,task):
        tasklist = self.RetreiveTasks()
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            for i in range(0,len(tasklist)):
                if tasklist[i][0] == task[0] and tasklist[i][1] == task[1] and tasklist[i][2] == task[2] and tasklist[i][3] == task[3] and tasklist[i][4] == task[4]:
                    cur.execute("DELETE FROM " + CONST_TABLE + " WHERE FUNCTYPE = ? AND COMP = ? AND TIME = ? AND DAY = ? AND DATE = ? " , task)


