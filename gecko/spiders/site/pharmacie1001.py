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

    def get_product_links(self, p_response):
        return p_response.response.xpath('//h2[contains(@class, "title order-1 mb-0")]/a')

    def get_product_url(self, p_product):
        return p_product.xpath(".//@href").extract_first()

    def get_product_next_page(self, p_product):
        return p_product.xpath('//li[contains(@class, "next")]/a/@href').extract_first()
    