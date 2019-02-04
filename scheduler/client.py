# Echo client program
import socket
import sys
from config import ReadConfig


conf = ReadConfig()

for node in conf.lst_nodes:
    print(node.id + " " + node.host + " " + node.port + " " + node.key)
    







HOST = "127.0.0.1"    # The remote host
PORT = 5008              # The same port as used by the server
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