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
            cur.execute("CREATE TABLE " + CONST_TABLE + " (FUNCTYPE TEXT, COMP TEXT, TIME TEXT)")


    def AddTask(self,task):
        con = sqlite3.connect(CONST_DB)
        with con:
            cur = con.cursor()
            cur.execute("INSERT INTO " + CONST_TABLE + "(FUNCTYPE, COMP, TIME) " + "VALUES(?,?,?)", task)

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
            for i in range(0,len(tasklist)-1):
                if tasklist[i][0] == task[0] and tasklist[i][1] == task[1] and tasklist[i][2] == task[2]:
                    cur.execute("DELETE FROM " + CONST_TABLE + " WHERE FUNCTYPE = ? AND COMP = ? AND TIME = ? ", task)


