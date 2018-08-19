# -*- coding: utf-8 -*-
# jsut for https://www.1001pharmacies.com/marques

import scrapy
from .geckologger import GeckoLogger
from ..items import GeckoItem

#scrapy.Spider
class CatalogSpider(scrapy.Spider):
    name = "catalog"
    logger = GeckoLogger("catalog", "log_catalog.log")

    def start_requests(self):
        urls=['https://www.1001pharmacies.com/marques']
        for url in urls:
            yield scrapy.Request(url=url, callback=self.parse)

    def parse(self, response):
        brand_item = GeckoItem()
        page = response.url.split("/")[-2]
        self.logger.debug('page name: %s' % response.url)
        self.logger.debug('Response status: %s' % response.status)

        # parse the page
        if response.status == 200:
            #self.logger.debug('analyser web begin')
            self.logger.debug(response.urljoin('/catalog'))
            
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


