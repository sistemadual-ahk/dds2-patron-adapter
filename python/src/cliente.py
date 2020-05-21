class Cliente(object):
    __adapter = None

    def setadapter(self, adapter):
        self.__adapter = adapter

    def ejecutar(self):
        # TODO
        self.__adapter.operacion()
        # TODO
