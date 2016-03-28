#Region - Imports
from scapy.all import *
#EndRegion - Imports

class Ping():

    def __init__(self,ip):
        self.ip = ip

    def Run(self): #Checkes if computer is Online or not
        packet = IP(dst=self.ip)/ICMP()
        replay = sr1(packet, timeout=1)
        
        
        if replay is None:
            return "Offline"
        else:    
            return "Online"



if __name__ == "__main__":
    test = Ping("10.92.5.81")
    x= test.Run()
    print x

