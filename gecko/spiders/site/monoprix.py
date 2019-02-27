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
        return p_products.xpath('//div[contains(@class, "grocery-item withGroceryItem2Style-hgq1p8-0 cclfld")]')
    
    def get_product_url(self, p_product):
        return p_product.xpath('.//a[@class="grocery-item__product-img"]/@href').extract_first()

    def get_product_next_page(self, p_product):
        return p_product.xpath('//div[contains(@class, "next-page")]/a/@href').extract_first()
    
    def get_product_brand_name(self, p_product):
        return p_product.xpath('//div[contains(@class, "product__brand")]/text()').extract_first()
    
    def get_product_name(self, p_product):
        return p_product.xpath('//div[@class="product__name"]/text()').extract_first()
    
    def get_product_short_description(self, p_product):
        return ''
    
    def get_product_weight(self, p_product):
        return p_product.xpath('//div[@class="product_conditioning"]/text()').extract_first()

    def get_product_long_description(self, p_product):
        return p_product.xpath('//div[@class="product__description-details"]/text()').extract_first()

    def get_product_usage(self, p_product):
        return ''

    def get_product_composition(self, p_product):
        return ''

    def get_product_ingredient(self, p_product):
        return p_product.xpath('//div[@class="product__ingredients-allergens-details"]/text()').extract_first()
    
    def get_product_conservation(self, p_product):
        return p_product.xpath('//div[@class="product__description-details"]/text()').extract_first()

    def get_product_nutrition(self, p_product):
        return p_product.xpath('//div[@class="Nutrition-tixjv9-0 djtlXr"]/text()').extract_first()

    def get_product_promotion(self, p_product):
        return p_product.xpath('//div[@class="promo_band _red"]/text()').extract_first()
    
    def get_product_price(self, p_product):
        return p_product.xpath('//div[@class="product__price"]/text()').extract_first()
