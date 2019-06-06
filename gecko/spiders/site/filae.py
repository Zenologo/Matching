class Filae:

    def __init__(self):
        pass
    
    def get_nom(self, p_page):
        return p_page.xpath('//div[contains(@class, "product__brand")]/text()').extract_first()