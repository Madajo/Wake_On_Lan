#Region - imports
import socket
import struct
from scapy.all import *
#EndRegion - imports

#Region - Constants
MAC_BROADCAST="ff:ff:ff:ff:ff:ff"

DST_PORT=9

DST_IP="255.255.255.255"

ADDR= (DST_IP, DST_PORT)

#EndRegion - Constants

class WakeUp():

    def __init__(self,mac_addr):
        self.mac_addr = mac_addr
        self.Fix()
        

    def Fix(self):

        if len(self.mac_addr) == 12:
            pass

        elif len(self.mac_addr) == 12 + 5:
            self.mac_addr = self.mac_addr.replace(self.mac_addr[2], '')
            print 'SW'
        else:
            raise ValueError('Incorrect MAC address format')
        
    def Run(self): #Sends a magic Packet in scapy
            
                
         #Scapy
        
        MAC_ADDR=self.mac_addr.decode("hex")

        mac_broadcast=MAC_BROADCAST.replace(MAC_BROADCAST[2], "").decode("hex")
        MagicPacket=Ether(dst=MAC_BROADCAST)/IP(dst=DST_IP)/UDP(dport=DST_PORT)/Raw(mac_broadcast+16*MAC_ADDR)

        for i in range(3):
            sendp(MagicPacket)
        

if __name__ == "__main__":
    testunit = WakeUp("6C-3B-E5-24-02-6F")
    testunit.Run()

