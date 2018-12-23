import os

print('begin example')


# Read task file then run spider

#os.system('scrapy crawl catalog -a arg=https://www.1001pharmacies.com/marques')
os.system('scrapy crawl product -a arg=https://www.1001pharmacies.com/marques')
# Read product task then run spider
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

