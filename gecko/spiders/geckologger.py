# -*- coding: utf-8 -*-
#
#
#

import os
import logging
from logging.handlers import RotatingFileHandler
from scrapy.utils.log import configure_logging


class GeckoLogger:
    """ Logger customized for write message in log file """

    logger = logging.getLogger('GeckoLogger')

    def __init__(self, new_name='GeckoLogger', file_name='log_root.log'):
        # 创建一个logger 
        self.logger = logging.getLogger(new_name)
        #self.logger.setLevel(logging.INFO)
        
        # 创建一个handler，用于写入日志文件 
        #file_handle = logging.FileHandler(file_name)
        file_path = os.path.dirname(os.path.realpath(__file__)) + '/../../log/'
        if not os.path.exists(file_path):
            os.makedirs(file_path)
        
        file_path = file_path + file_name
        print(file_path)


        file_handle = RotatingFileHandler(file_path + file_name, maxBytes=10240000, backupCount=5)
        file_handle.setLevel(logging.DEBUG)
        
        # 再创建一个handler，用于输出到控制台 
        #stdout_handle = logging.StreamHandler()
        #stdout_handle.setLevel(logging.INFO)
        
        # 定义handler的输出格式 
        formatter = logging.Formatter('%(asctime)s [%(name)s] - %(levelname)s : %(message)s')
        file_handle.setFormatter(formatter)
        #stdout_handle.setFormatter(formatter)

        # 给logger添加handler 
        self.logger.addHandler(file_handle)
       # self.logger.addHandler(stdout_handle)
    
    def debug(self, message):
        self.logger.debug(message)

    def info(self, message):
        self.logger.info(message)
    
    def warning(self, message):
        self.logger.warning(message)

    def error(self, message):
        self.logger.error(message)
