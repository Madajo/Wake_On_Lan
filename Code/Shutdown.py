
#Region - imports
import win32api
import win32con
import win32netcon
import win32security
import win32wnet
#EndRegion - imports
class Shutdown():
    

    def __init__(self,host=None, user=None, password=None, msg=None, timeout=0, force=1,
             reboot=0):
        self.host = host
        self.user = user
        self.password = password
        self.msg = msg
        self.timeout= timeout
        self.force = force
        self.reboot = reboot
    """ Shuts down a remote computer, requires NT-BASED OS. """
    
    # Create an initial connection if a username & password is given.
    def run(self):
        connected = 0
        if self.user:
            try:
                win32wnet.WNetAddConnection2(win32netcon.RESOURCETYPE_ANY, None,
                                             ''.join([r'\\', self.host]), None, self.user,
                                             self.password)
            # Don't fail on error, it might just work without the connection.
            except:
                pass
            else:
                connected = 1
        # We need the remote shutdown or shutdown privileges.
        p1 = win32security.LookupPrivilegeValue(self.host, win32con.SE_SHUTDOWN_NAME)
        p2 = win32security.LookupPrivilegeValue(self.host,
                                                win32con.SE_REMOTE_SHUTDOWN_NAME)
        newstate = [(p1, win32con.SE_PRIVILEGE_ENABLED),
                    (p2, win32con.SE_PRIVILEGE_ENABLED)]
        # Grab the token and adjust its privileges.
        htoken = win32security.OpenProcessToken(win32api.GetCurrentProcess(),
                                               win32con.TOKEN_ALL_ACCESS)
        win32security.AdjustTokenPrivileges(htoken, False, newstate)
        win32api.InitiateSystemShutdown(self.host, self.msg, self.timeout, self.force, self.reboot)
        # Release the previous connection.
        if connected:
            win32wnet.WNetCancelConnection2(''.join([r'\\', self.host]), 0, 0)


if __name__ == '__main__':
    # Immediate shutdown.
    x = Shutdown('ws674630', 'User', None, 'MORIS ', 9, reboot=1)
    x.run()
    # Delayed shutdown 30 secs.
    #Shutdown('salespc1', 'admin', 'secret', 'Maintenance Shutdown', 30)
    # Reboot
    #Shutdown('salespc1', 'admin', 'secret', None, 0, reboot=1)
    # Shutdown the local pc
    #Shutdown(None, 'admin', 'secret', None, 0)
