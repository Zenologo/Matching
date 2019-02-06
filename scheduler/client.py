# Echo client program
import socket
import sys, time
from config import ReadConfig


conf = ReadConfig()

for task in conf.lst_task:
    print(str(task.id) + " " + task.site + " " + task.type + " " + task.url + " " + time.strftime("%H:%M:%S", time.gmtime(task.run_time)))
    




for node in conf.lst_nodes:
    print(node.id + " " + node.host + " " + node.port + " " + node.key)
    HOST = "localhost"    #"127.0.0.1" 
    PORT = node.port    #50008
    
    s = None
    for res in socket.getaddrinfo(HOST, PORT, socket.AF_UNSPEC, socket.SOCK_STREAM):
        af, socktype, proto, canonname, sa = res
        try:
            s = socket.socket(af, socktype, proto)
        except OSError as msg:
            s = None
            continue
        try:
            s.connect(sa)
        except OSError as msg:
            s.close()
            s = None
            continue
        break
    if s is None:
        print('could not open socket')
        sys.exit(1)
    with s:
        s.sendall(b"Hello, world ! What's your name")
        data = s.recv(1024)
    print('Received from server', repr(data))