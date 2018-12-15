# -*- coding: utf-8 -*-

# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://doc.scrapy.org/en/latest/topics/item-pipeline.html

import os
from datetime import date
from scrapy.exporters import CsvItemExporter
from .spiders.geckologger import GeckoLogger

class GeckoPipeline(object):
    def process_item(self, item, spider):
        return item


class CsvPipeline(object):
    logger = GeckoLogger("CsvPipline", "log_csvpipeline.log")

    def __init__(self):
        self.files = {}

    def open_spider(self, spider):
        ''' Test get path '''

        file_path = os.getcwd() + '/../doc/site'  
        self.file = open("%s%s_%s.csv" % (file_path, spider.name, date.today()), 'wb')
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
"""
    # 重写item_completed方法
    # 将下载的文件保存到不同的目录中
    def item_completed(self, results, item, info):
        image_path = [x["path"] for ok, x in results if ok]

        # 定义分类保存的路径
        img_path = "%s%s"%(self.img_store, item['img_path'])
        # 目录不存在则创建目录
        if os.path.exists(img_path) == False:
            os.mkdir(img_path)

        # 将文件从默认下路路径移动到指定路径下
        shutil.move(self.img_store + image_path[0], img_path + "\\" + item["img_name"] + '.jpg')

        item["img_path"] = img_path + "\\" + item["img_name"] + '.jpg'
        return item
"""