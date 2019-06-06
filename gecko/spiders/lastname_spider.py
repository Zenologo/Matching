# -*- coding: utf-8 -*-
#  For Lastname french

import scrapy
import os
import csv
from datetime import datetime
from w3lib.html import remove_tags
from .geckologger import GeckoLogger
from ..items import LastnameItem
from .toolkit import check_doc_folder, get_subfolders, get_parse_module

class LastnameSpider(scrapy.Spider):
    name = "lastname"
    logger = GeckoLogger("lastname", "log_lastname.log")
    url_string = ""
    dir_path = ""
    file_name = ""
    site = ""
    site_parse = None
    usrls=[]

    def __init__(self, **kwarg):
        self.urls = [kwarg['arg']]

        # Get site's name
        self.site = self.urls[0].split('//')[-1].split('/')[0]
        if self.site[0:4] == "www.":
            self.site = self.site[4:]
        pos_point = self.site.find(".")
        if pos_point > 0:
            self.site = self.site[0:pos_point]
        #self.set_parse_module()
        self.site_parse = get_parse_module(self.site)


    def start_requests(self):
        for url in self.urls:
            self.verify_path(url)
            yield scrapy.Request(url = url, callback = self.parse,  meta = {'dont_redirect': True})



    def verify_path(self, url):
        """
            Verify site's directory.
        """
        check_doc_folder()

        site = url.split('//')[-1].split('/')[0]
        if site[0:4] == "www.":
            site = site[4:]
 
    def parse(self, response):
        self.logger.debug("response status: %s" % str(response.status))

        lastname_item = LastnameItem()
        page = response.url.split("-")[-2]   

        # parse the page
        if response.status == 200:
            self.logger.debug(response.urljoin('/catalog'))

            brands = self.site_parse.get_brands(response)
            for brand in brands:
                brand_link = self.site_parse.get_brand_link(brand)
                print(brand_link)
                brand_name = self.site_parse.get_brand_name(brand)
                print(brand_name)
                brand_item['brand_link'] = response.urljoin(brand_link)
                brand_item['brand'] = brand_name
                brand_item['created_time'] = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
                yield brand_item
        else:
            filename = 'catalog-%s.html' % page
            with open(filename, 'wb') as f:
                f.write(response.body)



