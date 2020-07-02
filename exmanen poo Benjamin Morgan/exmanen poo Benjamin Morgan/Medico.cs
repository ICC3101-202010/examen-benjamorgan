using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmanen_poo_Benjamin_Morgan
{
    [Serializable()]
    class Medico : Persona
    {
        private int PXperencia { get; set; } // estre mas alto mejor 



        public void Evaluar()
        {
            // ve la salud de un jugador, si esta es baja (menor a 70) lo puede curar (cura 1 por cada punto de experencia del medico)
        }

        public void Curar()
        {
            // aunmenta la salud del jugador en PXperencia puntos, con el limite de 100 
        }

        public Medico(string nombre,string nacion, int edad, int sueldo, int experencia) : base(nombre, nacion,edad,sueldo)
        {
            this.PXperencia = experencia;
        }

    }

}
