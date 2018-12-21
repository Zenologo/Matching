import os

print('begin example')


# Read task file then run spider

os.system('scrapy crawl catalog -a argu=https://www.1001pharmacies.com/marques')

# Read product task then run spider

print('end example')

