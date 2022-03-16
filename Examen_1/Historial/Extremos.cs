using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen_1.Menu;
using Examen_1.Dados;

namespace Examen_1.Historial
{
    class Extremos
    {
        private string _numero_Extremo;

        public Extremos(string numero_Extremo)
        {
            _numero_Extremo = numero_Extremo;
        }

        public string numero_Extremo
        {
            get { return _numero_Extremo; }
            set { _numero_Extremo = value; }
        }

        public override string ToString()
        {
            return $"Resultados extremos: {_numero_Extremo}";
        }
    }
}
