using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.Historial
{
    class NumeroMenos
    {
        private string _numero_Menos;

        public NumeroMenos(string numero_Menos)
        {
            _numero_Menos = numero_Menos;
        }

        public string numero_Menos
        {
            get { return _numero_Menos; }
            set { _numero_Menos = value; }
        }

        public override string ToString()
        {
            return $"Numero menos tirado: {_numero_Menos}";
        }
    }
}
