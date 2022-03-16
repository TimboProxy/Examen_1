using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1.Jugador
{
    class Decision
    {
        private string _id_unidad;

        public Decision(string id_unidad)
        {
            _id_unidad = id_unidad;
        }

        public string id_undidad
        {
            get { return _id_unidad; }
            set { _id_unidad = value; }
        }

        public override string ToString()
        {
            return $"Id: {_id_unidad}";
        }
    }
}
