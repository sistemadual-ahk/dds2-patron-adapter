using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_template.src.dominio.adapters
{
    class AdapterConcretoA : IAdapter
    {
        private AdaptadaA adaptada;

        public void setAdaptada(AdaptadaA adaptada)
        {
            this.adaptada = adaptada;
        }

        public void operacion()
        {
            this.adaptada.operacionRealA();
        }
    }
}
