import os
import sched, time, random
from datetime import date



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

run_gecko()
"""
from scrapy.cmdline import execute

try:
    execute(
        [
            'scrapy',
            'crawl',
            'product',
            '-a arg==https://www.1001pharmacies.com/marques',
             
        ]
    )
except SystemExit:
    pass
"""
print('end example')

