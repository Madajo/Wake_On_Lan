import wmi
import socket, sys, os



#---------------------------------
def getNetworkAtrr():
    wmi_obj = wmi.WMI()
    sql = "select MACAddress, IPAddress,DefaultIPGateway,IPSubnet from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE"
    wmi_out = wmi_obj.query(sql)
    MY_IP, GATEWAY_IP, My_Mac = wmi_out[0].IPAddress[0] ,wmi_out[0].DefaultIPGateway[0] ,wmi_out[0].MACAddress
    SUBNETMASK = wmi_out[0].IPSubnet[0]
    return MY_IP, GATEWAY_IP, My_Mac,SUBNETMASK

#---------------------------------
def ExponentTwo(num):
    num = int(num)
    times = 0
    while num>0:
        if num % 2 != 0:
            times = times + 1
        num = num / 2
    return times

#---------------------------------
def And(gW,mask):
    return int(gW) & int(mask)   
   
#---------------------------------
def GetFinGateWay(GateWayIP,SubNetMask):
    GateArray = GateWayIP.split(".",4)
    MaskArray = SubNetMask.split(".",4)
    addbits = ExponentTwo(MaskArray[0]) + ExponentTwo(MaskArray[1]) + ExponentTwo(MaskArray[2]) + ExponentTwo(MaskArray[3])   
    
    FinalGatway  = str( And(GateArray[0],MaskArray[0])) + "."
    FinalGatway += str( And(GateArray[1],MaskArray[1])) + "."
    FinalGatway += str( And(GateArray[2],MaskArray[2])) + "."
    FinalGatway += str( And(GateArray[3],MaskArray[3])) 
    FinalGatway += "/" + str(addbits)
    return FinalGatway
