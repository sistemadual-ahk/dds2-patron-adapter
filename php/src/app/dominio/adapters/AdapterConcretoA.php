<?php
namespace dominio\adapters;


class AdapterConcretoA implements IAdapter {
    /**
     * @var AdaptadaA
     */
    private $adaptada;

    public function setAdaptada(AdaptadaA $adaptada){
        $this->adaptada = $adaptada;
    }

    public function operacion(){
        $this->adaptada->operacionRealA();
    }
}