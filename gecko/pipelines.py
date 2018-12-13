# -*- coding: utf-8 -*-

# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://doc.scrapy.org/en/latest/topics/item-pipeline.html


from datetime import date
from scrapy.exporters import CsvItemExporter

class GeckoPipeline(object):
    def process_item(self, item, spider):
        return item


class CsvPipeline(object):
    def __init__(self):
        self.files = {}

    def open_spider(self, spider):
        self.file = open("%s_%s.csv" % (spider.name, date.today()), 'wb')
        self.exporter = CsvItemExporter(self.file, True)
        self.exporter.start_exporting()

    def close_spider(self, spider):
        self.exporter.finish_exporting()
        self.file.close()

    def process_item(self, item, spider):
        self.exporter.export_item(item)
        #del item['crawlid']
        #del item['appid']
        return item