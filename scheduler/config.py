import configparser

class ReadConfig:
    config = None
    node_available = 0
    lst_nodes = []

    def __init__(self):
        self.config = configparser.ConfigParser()
        self.config.read("conf.ini")
        self.port = self.config.get("Local", "port")
        self.cmd_items = self.config.items("CMD")
        self.nodes_items = self.config.items("Nodes")
        self.parse_node()

    def get_port(self):
        return self.port
    
    def parse_node(self):
        id = None
        host = None
        port = None
        key = None
        for node in self.nodes_items:
            node_name = node[0].split("_")
            
            if (id == None):
                id = node_name[1]

            if (node_name[1] == id and node_name[0] == "host"):
                host = node[1]
            elif (node_name[1] == id and node_name[0] == "port"):
                port = node[1]
            elif (node_name[1] == id and node_name[0] == "key"):
                key = node[1]

            if (id != None and host != None and port != None and key != None):
                self.lst_nodes.append(NodeDownload(id, host, port, key))
                id = None
                host = None
                port = None
                key = None

    def get_count_node(self):
        return len(self.lst_nodes)

    def get_node(self, p_index):
        return self.lst_nodes[p_index]

    def print_lst_nodes(self):
        for node in self.lst_nodes:
            print(node.id + " " + node.host + " " + node.port + " " + node.key)

class NodeDownload:
    def __init__(self, p_id, p_host, p_port, p_key):
        self.id = p_id
        self.host = p_host
        self.port = p_port
        self.key = p_key
    
