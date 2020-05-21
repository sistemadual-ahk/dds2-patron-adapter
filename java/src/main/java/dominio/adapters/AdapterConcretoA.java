package dominio.adapters;

public class AdapterConcretoA implements IAdapter{
    private AdaptadaA adaptada;

    public void setAdaptada(AdaptadaA adaptada) {
        this.adaptada = adaptada;
    }

    @Override
    public void operacion() {
        this.adaptada.operacionRealA();
    }
}