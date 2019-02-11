#
# Parsing rule of site 1001pharmacie.
#
import scrapy

class Pharmacie1001:

    def __init__(self):
        pass
    
    def get_brands(self, p_response):
        return p_response.xpath('//a[contains(@class, "link--normal")]')

    def get_brand_link(self, p_brand):
        return p_brand.xpath('.//@href').extract_first()
    
    def get_brand_name(self, p_brand):
        return p_brand.xpath('.//text()').extract_first()

