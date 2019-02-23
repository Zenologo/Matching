class Monoprix:

    def __init__(self):
        pass
    
    # Tous les rayons(catalogue)
    def get_brands(self, p_response):
        return p_response.xpath('//li[contains(@class, "menu--seo--column1")]')
    
    def get_brand_link(self, p_brand):
        return p_brand.xpath('.//@href').extract_first()
    
    def get_brand_name(self, p_brand):
        return p_brand.xpath('.//text()').extract_first()

    def get_product_links(self, p_products):
        return p_products.xpath('.//div[contains(@class, "grocery-item withGroceryItem2Style-hgq1p8-0 cclfld")]')
    
    def get_product_url(self, p_product):
        return p_product.xpath(".//@href").extract_first()

    def get_product_next_page(self, p_product):
        return p_product.xpath('.//div[contains(@class, "next-page")]/a/@href').extract_first()