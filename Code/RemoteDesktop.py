#Region -- Imports
import subprocess

#EndRegion -- Imports

class RemoteDesktop():
    def __init__(self,server):
        self.server = server

    def Run(self):
        subprocess.Popen(["mstsc" , "/v:" , self.server])


if __name__ == "__main__":
    x = RemoteDesktop("10.92.5.34")
    x.Run()