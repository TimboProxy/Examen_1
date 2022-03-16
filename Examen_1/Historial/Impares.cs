using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.Historial
{
    class Impares
    {
        private string _numeros_Impar;

        public Impares(string numeros_Impar)
        {
            _numeros_Impar = numeros_Impar;
        }

        public string numeros_Impar
        {
            get { return _numeros_Impar; }
            set { _numeros_Impar = value; }
        }

        public override string ToString()
        {
            return $"Resultados Impares: {_numeros_Impar}";
        }
    }
}
