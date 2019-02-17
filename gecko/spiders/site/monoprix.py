class Monoprix:

    def __init__(self):
        pass
    
    # Tous les rayons
    def get_brands(self, p_response):
        return p_response.xpath('//li[contains(@class, "menu--seo--column1")]')