using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.Historial
{
    class Pares
    {
        private string _numeros_Par;

        public Pares(string numeros_Par)
        {
            _numeros_Par = numeros_Par;
        }

        public string numeros_Par
        {
            get { return _numeros_Par; }
            set { _numeros_Par = value; }
        }

        public override string ToString()
        {
            return $"Resultados Pares: {_numeros_Par}";
        }
    }
}
