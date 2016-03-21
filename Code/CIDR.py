import wmi
import socket, sys, os


class Network():
#---------------------------------
    def __init__(self):
        wmi_obj = wmi.WMI()
        sql = "select MACAddress, IPAddress,DefaultIPGateway,IPSubnet from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE"
        wmi_out = wmi_obj.query(sql)
        self.MY_IP, self.GATEWAY_IP, self.My_Mac = wmi_out[0].IPAddress[0] ,wmi_out[0].DefaultIPGateway[0] ,wmi_out[0].MACAddress
        self.SUBNETMASK = wmi_out[0].IPSubnet[0]
        

#---------------------------------
    def ExponentTwo(self,num):
        num = int(num)
        times = 0
        while num>0:
            if num % 2 != 0:
                times = times + 1
            num = num / 2
        return times

#---------------------------------
    def And(self,gW,mask):
        return int(gW) & int(mask)   
   
#---------------------------------
    def GetFinGateWay(self):
        GateArray = self.GATEWAY_IP.split(".",4)
        MaskArray = self.SUBNETMASK.split(".",4)
        addbits = ExponentTwo(MaskArray[0]) + ExponentTwo(MaskArray[1]) + ExponentTwo(MaskArray[2]) + ExponentTwo(MaskArray[3])   
    
        FinalGatway  = str( And(GateArray[0],MaskArray[0])) + "."
        FinalGatway += str( And(GateArray[1],MaskArray[1])) + "."
        FinalGatway += str( And(GateArray[2],MaskArray[2])) + "."
        FinalGatway += str( And(GateArray[3],MaskArray[3])) 
        FinalGatway += "/" + str(addbits)
        return FinalGatway
