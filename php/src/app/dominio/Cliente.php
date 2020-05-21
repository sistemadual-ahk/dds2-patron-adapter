<?php
namespace dominio;

use dominio\adapters\IAdapter;

class Cliente {
    /**
     * @var IAdapter
     */
    private $adapter;

    public function setAdapter(IAdapter $adapter){
        $this->adapter = $adapter;
    }

    public function ejecutar(){
        //TODO
        $this->adapter->operacion();
        //TODO
    }
}