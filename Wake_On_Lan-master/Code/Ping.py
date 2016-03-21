#Region - Imports
from scapy.all import *

#EndRegion - Imports

class Ping():

    def __init__(self,ip):
        self.ip = ip

    def Run(self): #Checkes if computer is Online or not
        packet = Ether(dst="ff:ff:ff:ff:ff:ff")/ARP(pdst=self.ip)
        ans,uans = srp(packet,timeout=1)

        for i in ans:
            if i[1][ARP].psrc == self.ip:
                print i[1][Ether].src #Sends Computer MAC address
                
            else:
                return "Offline"


                
        return "Online"



if __name__ == "__main__":
    test = Ping("10.92.5.99")
    x= test.Run()
    print x

