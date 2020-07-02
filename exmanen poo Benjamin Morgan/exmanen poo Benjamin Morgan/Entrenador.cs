using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmanen_poo_Benjamin_Morgan
{
    [Serializable()]
    class Entrenador:Persona
    {
        private int Ptactica { get; set; }



        public void Cambiar_Jugador()
        {
            // de los 11 jugadores en cancha cambia 1 con otro de la banca, en caso de cambiar el arquero revisa que quien entre tenga la posicion arquero
            //se ejecuta si la salud de un jugador llega a ser muy baja o si alguno se lesiona
        }

        public Entrenador(string nombre, string nacion, int edad, int sueldo, int puntosTacticos) : base(nombre,nacion,edad,sueldo)
        {
            this.Ptactica = puntosTacticos;
        }
    }
}
