#Region - imports
import socket
import struct
#EndRegion - imports

#Region - Constants
MAC_BROADCAST = "ff:ff:ff:ff:ff"
DST_IP = "<broadcast>"
DST_PORT = 7
ADDR = (DST_IP,DST_PORT)
#EndRegion - Constants

class WakeUp():

    def __init__(self,mac_addr):
        self.mac_addr = mac_addr

    def Run(self): #Sends a magic Packet in scapy
        dot = MAC_BROADCAST[2]
        mac_broadcast = MAC_BROADCAST.replace(dot,'')
        mac_addr = self.mac_addr
        MAC_ADDR = mac_addr.replace(mac_addr[2] ,'')
        data = ''.join([mac_broadcast,MAC_ADDR*20])
        send_to =''
        for i in range(0, len(data), 2):
            send_to += struct.pack('B',int(data[i:i+2],16))
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        sock.setsockopt(socket.SOL_SOCKET, socket.SO_BROADCAST, 1)
        for i in xrange(3):
            sock.sendto(send_to, ADDR)



#Test
testunit = WakeUp("38-60-77-20-BD-8C")
testunit.Run()
