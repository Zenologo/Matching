# -*- coding: utf-8 -*-
#
# This file includes all classes and functions for capture
# brand's info from site 1001pharmacies.com
#
# Thanks for the page "/marques" who list all brand's link.
#


import scrapy
import os
from .geckologger import GeckoLogger
from ..items import GeckoItem
from datetime import datetime

#scrapy.Spider
class CatalogSpider(scrapy.Spider):
    name = "catalog"
    logger = GeckoLogger("catalog", "log_catalog.log")
    site = ''
    usrls=[]

    def __init__(self):
        self.site = 'kjlkj'
        self.urls=['https://www.1001pharmacies.com/marques']

    def start_requests(self):        
        # Init task site and download site
        for url in self.urls:
            self.verify_path(url)
            yield scrapy.Request(url = url, callback = self.parse)

    def verify_path(self, url):
        """ Verify site's directory,  if exists. if not create it.
            Doc
                [Site name]
                    [catagory]
                    [product]
        """
        test_path = os.path.dirname(os.path.realpath(__file__))
        #self.logger.debug('current directory: %s' %  dir_path)
        test_path = test_path + "/../doc"
        if not os.path.exists(test_path) :
            os.makedirs(test_path)
        site = url.split('//')[-1].split('/')[0]
        if site[0:4] == "www.":
            site = site[4:]
        #dir_path += '/' + site + "/brands"
        if not os.path.exists(test_path):
            os.makedirs(test_path + '')


    def parse(self, response):
        """ Parse page if sucess, if not save page's source in local """
        brand_item = GeckoItem()
        page = response.url.split("/")[-2]
        #self.logger.debug('page name: %s' % response.url)
        #self.logger.debug('Response status: %s' % response.status)
        
        # parse the page
        if response.status == 300:
            #self.logger.debug('analyser web begin')
            #self.logger.debug(response.urljoin('/catalog'))
            
            brands = response.xpath('//a[contains(@class, "link--normal")]')
            for brand in brands:
                brand_link = brand.xpath('.//@href').extract_first()
                brand_name = brand.xpath('.//text()').extract_first()
                brand_item['brand_link'] = response.urljoin(brand_link)
                brand_item['brand'] = brand_name
                #self.logger.debug(brand_link)
                #self.logger.debug(response.urljoin(brand_link))
                #self.logger.debug(brand_name)
                yield brand_item
        else:
            filename = 'catalog-%s.html' % page
            with open(filename, 'wb') as f:
                f.write(response.body)


