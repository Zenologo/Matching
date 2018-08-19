# -*- coding: utf-8 -*-
# jsut for 1001pharmacies.com's products

import scrapy
import os
import csv
from .geckologger import GeckoLogger
from ..items import BrandItem, ProductItem

#scrapy.Spider
class ProductSpider(scrapy.Spider):
    name = "product"
    logger = GeckoLogger("product", "log_product.log")

    def start_requests(self):
        urls = self.read_brands()
        for url in urls:
            yield scrapy.Request(url = url['brand_link'], callback=self.parse_brand)

    def set_url(self, url):
        pass

    def read_brands(self):
        """ Read brand file and  """
        dir_path = os.path.dirname(os.path.realpath(__file__))
        self.logger.debug('current directory: %s' %  dir_path)
        path_directory = dir_path + "/../../doc/1001pharmacies/"
        self.logger.debug(path_directory)
        dirs = os.listdir(path_directory)

        last_dir = ''
        for file in dirs:
            self.logger.debug(file)
            if file > last_dir:
                last_dir = file
        self.logger.debug('last dir %s' % last_dir)
        path_directory = f'{path_directory}{last_dir}'
        path_brands_file = f'{path_directory}/brands.csv'
        self.logger.debug(path_brands_file)
        if os.path.isfile(path_brands_file):
            self.logger.debug("brands cvs file is exist")
            limit = 3
            with open(path_brands_file, newline='', encoding='utf-8') as brand_file:
                reader = csv.DictReader(brand_file)
                for row in reader:
                    if limit == 0:
                        break
                    yield row
                    limit -= 1
        else:
            self.logger.debug("brands cvs file is not exist")



    def parse_brand(self, response):
        """ Parse brand page """
        product_item = ProductItem()
        page = response.url.split("/")[-2]
        #self.logger.debug('page name: %s' % response.url)
        #self.logger.debug('Response status: %s' % response.status)

        # parse the page
        if response.status == 200:
            #self.logger.debug('analyser web begin')
            #self.logger.debug(response.urljoin('/catalog'))
            """ parse page """
            brand_name = response.xpath('//h2[contains(@class, "title-brand--king text--gray-medium")]/text()').extract_first()
            #products = response.xpath('//h3[contains(@class, "title order-2")]/a/@href')
            products = response.xpath('//h3[contains(@class, "title order-2")]/a')

            for product in products:
                tmp_value = product.xpath(".//text()").extract_first()
                product_item['product_name'] = tmp_value.strip()

                tmp_value = product.xpath(".//@href").extract_first()
                product_item['product_url'] = tmp_value.strip()


                self.logger.debug(product_item['product_name'].strip())
                self.logger.debug(product_item['product_url'].strip())
                yield product_item


            #brands = response.xpath('//a[contains(@class, "link--normal")]')

            """
            for brand in brands:
                brand_link = brand.xpath('.//@href').extract_first()
                brand_name = brand.xpath('.//text()').extract_first()
                brand_item['brand_link'] = response.urljoin(brand_link)
                brand_item['brand'] = brand_name
                #self.logger.debug(brand_link)
                #self.logger.debug(response.urljoin(brand_link))
                #self.logger.debug(brand_name)
                yield brand_item
            """
        else:
            filename = 'catalog-%s.html' % page
            with open(filename, 'wb') as f:
                f.write(response.body)


