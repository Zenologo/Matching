import os, sys, socket
import sched, time, random
from datetime import date
from config import ReadConfig




def path_existed():
    """ If directory is existed that mean """
    dir_path = os.path.dirname(os.path.realpath(__file__))
    dir_path = dir_path + "/doc/" + date.today().isoformat()
    print(dir_path)
    if os.path.exists(dir_path) :
        return True
    else:
        return False



s = sched.scheduler(time.time, time.sleep)
def run_gecko():
    """
    os.system('scrapy crawl catalog -a arg=https://www.1001pharmacies.com/marques')
    print("Catalog END")
    time.sleep(2) # Sleep 1 second
    os.system('scrapy crawl product -a arg=https://www.1001pharmacies.com/marques')
    print("Product END")
    time.sleep(2) # Sleep 1 second
    """
    os.system('scrapy crawl catalog -a arg=https://www.monoprix.fr/courses-en-ligne')
    print("Product END")    
"""    
    if not path_existed():
        print("path doesn't existed")
        os.system('scrapy crawl catalog -a arg=https://www.1001pharmacies.com/marques')
        print("catalog")
        time.sleep(2) # Sleep 1 second
        os.system('scrapy crawl product -a arg=https://www.1001pharmacies.com/marques')
        print("product")
    else:
        print("path existed")
    total = random.randint(1, 5)
    print(total)
    s.enter(total, 1 , run_gecko)
    s.run()
"""
        # os.system('scrapy crawl catalog -a arg=https://www.1001pharmacies.com/marques')
        # time.sleep(1) # Sleep 1 second
        # os.system('scrapy crawl product -a arg=https://www.1001pharmacies.com/marques')

print('begin example')

#Todo: 1. Scan the folder "doc" and verify the name of sub-folder.
#         If the today's sub-f older doesn't existed: run gecko.
#         else goto sleep.

# Read task file then run spider

# os.system('scrapy crawl catalog -a arg=https://www.1001pharmacies.com/marques')
# time.sleep(1) # Sleep 1 second

# os.system('scrapy crawl product -a arg=https://www.1001pharmacies.com/marques')

# Read product task then run spider


#TODO: 1. run server for wait cmd; DONE
#      2. if there is not cmd during 24 hours then run function automatically

run_gecko()



conf = ReadConfig()

HOST = conf.get_host()
PORT = conf.get_port()
print (HOST)
print (PORT)


HOST = "127.0.0.1"
PORT = 5008

local_socket = None
for res in socket.getaddrinfo(HOST, PORT, socket.AF_UNSPEC,
                              socket.SOCK_STREAM, 0, socket.AI_PASSIVE):
    af, socktype, proto, canonname, sa = res

    try:
        local_socket = socket.socket(af, socktype, proto)
    except OSError as msg:
        local_socket = None
        continue

    try:
        local_socket.bind(sa)
        local_socket.listen(1)
    except OSError as msg:
        local_socket.close()
        print("Socket is closed")
        local_socket = None
        continue
    break

if local_socket is None:
    print('Could not open socket')
    sys.exit(1)

print("before conn ")

while True:
    counter = 0
    conn, addr = local_socket.accept()
    with conn:
        print('Connected by', addr)
        while True:
            data = conn.recv(1024)
            if not data: break
            print("recev data: ")
            print(data)
            print("")
            conn.send(b"yes, what do you want to do ? ")
    
    








# print(items[1])

print('end example')

