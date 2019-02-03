import configparser

class ReadConfig():
    config = None

    def __init__(self):
        self.config = configparser.ConfigParser()
        self.config.read("conf.ini")
        self.port = self.config.get("Local", "port")
        self.cmd_items = self.config.items("CMD")
        self.nodes_items = self.config.items("nodes")

    def get_port(self):
        return self.port

