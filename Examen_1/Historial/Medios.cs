using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.Historial
{
    class Medios
    {
        private string _numero_Medio;

        public Medios(string numero_Medio)
        {
            _numero_Medio = numero_Medio;
        }

        public string numero_Medio
        {
            get { return _numero_Medio; }
            set { _numero_Medio = value; }
        }

        public override string ToString()
        {
            return $"Resultados medios: {_numero_Medio}";
        }
    }
}
