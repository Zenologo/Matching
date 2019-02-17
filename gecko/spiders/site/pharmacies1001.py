#
# Parsing rule of site 1001pharmacie.
#
import scrapy

class Pharmacies1001:

    def __init__(self):
        pass
    
    def get_brands(self, p_response):
        return p_response.xpath('//a[contains(@class, "link--normal")]')

    def get_brand_link(self, p_brand):
        return p_brand.xpath('.//@href').extract_first()
    
    def get_brand_name(self, p_brand):
        return p_brand.xpath('.//text()').extract_first()

    def get_product_links(self, p_response):
        return p_response.xpath('//h2[contains(@class, "title order-1 mb-0")]/a')

    def get_product_url(self, p_product):
        return p_product.xpath(".//@href").extract_first()

    def get_product_next_page(self, p_product):
        return p_product.xpath('//li[contains(@class, "next")]/a/@href').extract_first()
    
    def get_product_brand_name(self, p_product):
        return p_product.xpath('//h2[contains(@itemprop, "brand")]/a/span/text()').extract_first()
    
    def get_product_name(self, p_product):
        return p_product.xpath('//h1[@class="order-1" and @itemprop="name"]/text()').extract_first()

    def get_product_short_description(self, p_product):
        return p_product.xpath('//div[@itemprop="description"]').extract_first()
    
    def get_product_weight(self, p_product):
        return p_product.xpath('//div[@itemprop="weight"]/span/text()').extract_first()

    def get_product_long_description(self, p_product):
        return p_product.xpath('//div[@id="longDescription"]').extract_first()

    def get_product_usage(self, p_product):
        return p_product.xpath('//div[@id="usage"]').extract_first()
    
    def get_product_composition(self, p_product):
        return p_product.xpath('//div[@id="composition"]').extract_first()

    def get_product_price(self, p_product):
        return p_product.xpath('//p[@class="price"]/meta[@itemprop="price"]/@content').extract_first()