class Monoprix:

    def __init__(self):
        pass
    
    # Tous les rayons
    def get_brands(self, p_response):
        return p_response.xpath('//li[contains(@class, "menu--seo--column1")]')
    
    def get_brand_link(self, p_brand):
        return p_brand.xpath('.//@href').extract_first()
    
    def get_brand_name(self, p_brand):
        return p_brand.xpath('.//text()').extract_first()