using adapter_template.src.dominio.adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_template.src.dominio
{
    class Cliente
    {
        private IAdapter adapter;

        public void setAdapter(IAdapter adapter)
        {
            this.adapter = adapter;
        }

        public void ejecutar()
        {
            //TODO
            this.adapter.operacion();
            //TODO
        }
    }
}
