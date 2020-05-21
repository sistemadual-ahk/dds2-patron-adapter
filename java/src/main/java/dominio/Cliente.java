package dominio;

import dominio.adapters.IAdapter;

public class Cliente {
    private IAdapter adapter;

    public void setAdapter(IAdapter adapter) {
        this.adapter = adapter;
    }

    public void ejecutar(){
        //TODO
        this.adapter.operacion();
        //TODO
    }
}