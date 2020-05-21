from src.adapters.iadapter import IAdapter


class AdapterConcretoA(IAdapter):
    __adaptada = None

    def setadaptada(self, adaptada):
        self.__adaptada = adaptada

    def operacion(self):
        self.__adaptada.operacion_real_a()
