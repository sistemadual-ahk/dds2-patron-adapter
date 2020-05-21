import abc


class IAdapter(abc.ABC):

    @abc.abstractmethod
    def operacion(self):
        pass
