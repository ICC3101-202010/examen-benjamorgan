using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmanen_poo_Benjamin_Morgan
{
    [Serializable()]
    class Jugador : Persona
    {
        private int Patake { get; set; }
        private int Pdefensa { get; set; }
        private int NumeroCamiseta { get; set; }
        private string poscicion { get; set; }
        private int salud { get; set; } //la salud se expresa con un numero de rendimiento que va de 0 a 100



        public Jugador(string nombre, string nacion,int edad,int sueldo, int puntosAtake, int puntosDefensa,int Numero,int salud, string poscicion) : base(nombre,nacion,edad,sueldo)
        {
            this.Patake = puntosAtake;
            this.Pdefensa = puntosDefensa;
            this.NumeroCamiseta = Numero;
            this.poscicion = poscicion;
            this.salud = salud;
        }


    }
}
