using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmanen_poo_Benjamin_Morgan
{
    [Serializable()]
    abstract class Persona
    {
        protected string Nombre { get; set; }
        protected int Edad { get; set; }
        protected string Nacion { get; set; }
        protected int Sueldo { get; set; }

        public Persona(string nombre, string nacion, int edad, int sueldo)
        {
            this.Nombre = nombre;
            this.Nacion = nacion;
            this.Edad = edad;
            this.Sueldo = sueldo;
        }
        public string Informacion()
        {
            return "Nombre: "+ Nombre + "; Edad: "+Edad +"; Nacion: "+Nacion+ "; Sueldo: "+Sueldo;
        }
        public string get_nacionalidad()
        {
            return  Nacion;
        }
    }
}
