"""
All function are using for the project. 
"""

import os
from .site import pharmacies1001, monoprix

def check_doc_folder():
    """
        Verify folder 'doc' if exists. if not create it.
    """
    dir_path = os.path.dirname(os.path.realpath(__file__))
    #self.logger.debug('current directory: %s' %  dir_path)
    path_directory = dir_path + "/../../doc"
    if not os.path.exists(path_directory) :
        os.makedirs(path_directory)
    return path_directory

def get_subfolders(doc_folder_path, file_name):
    """
        Return a list of files with the file_name.
    """
    list_file = []
    for root, dirs, files in os.walk(doc_folder_path):  
        for file in files:
            if file == file_name and file.find(".bk", len(file)-3) == -1:
                list_file.append(os.path.join(root, file))
    return list_file


def get_parse_module(p_site):
    """
        Return an instant of parser.
    """
    if (p_site == "1001pharmacies"):
        return pharmacies1001.Pharmacies1001()
    if(p_site == "monoprix"):
        return monoprix.Monoprix()