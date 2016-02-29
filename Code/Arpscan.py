#Region -- Imports
from scapy.all import *
#EndRegion -- Imports
pp =[]
class Arpscan():

    def __init__(self,Gateway):

        self.arplist = []
        self.Gateway = Gateway

    def Scan(self): #Scans all computers on local Networks

        packet  = Ether(dst="ff:ff:ff:ff:ff:ff")/ARP(pdst = self.Gateway)
        ans, uans = srp(packet, timeout=2)
        for i in ans:

            print i[1][ARP].psrc + " - " + i[1][ARP].hwsrc

            self.arplist.append( (i[1][ARP].psrc + " - " + i[1][ARP].hwsrc) )

        return self.arplist


if __name__ == "__main__":
    x = Arpscan("10.92.5.99/24")
    pp = x.Scan()
    print pp
