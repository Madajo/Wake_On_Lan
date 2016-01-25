#Region - Imports
from scapy.all import *

#EndRegion - Imports

class Ping():

    def __init__(self,ip):
        self.ip = ip

    def Run(self):
        packet = Ether(dst="ff:ff:ff:ff:ff:ff")/ARP(pdst=self.ip)
        ans,uans = srp(packet,timeout=3)

        for i in ans:
            if i[1][ARP].psrc == self.ip:
                return True


        return False




if __name__ == "__main__":
    test = Ping("10.92.5.50")
    x= test.Run()
    print x
