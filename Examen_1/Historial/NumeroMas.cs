using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.Historial
{
    class NumeroMas
    {
        private string _numero_Mas;

        public NumeroMas(string numero_Mas)
        {
            _numero_Mas = numero_Mas;
        }

        public string numero_Mas
        {
            get { return _numero_Mas; }
            set { _numero_Mas = value; }
        }

        public override string ToString()
        {
            return $"Numero mas tirado: {_numero_Mas}";
        }
    }
}
