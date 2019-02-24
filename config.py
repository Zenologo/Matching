import configparser

class ReadConfig():
    config = None

    def __init__(self):
        self.config = configparser.ConfigParser()
        self.config.read("conf.ini")
        self.host = self.config.get("Server", "host")
        self.port = self.config.get("Server", "port")
        self.cmd_key = self.config.get("CMD", "key")
        self.cmd_items = self.config.items("CMD")

    def get_host(self):
        return self.host

    def get_port(self):
        return self.port

    def get_cmd_key(self):
        return self.cmd_key
    
    def is_cmd(self, cmd_value):
        for item in self.cmd_items:
            if item[1] == cmd_value:
                return True
