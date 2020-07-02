using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exmanen_poo_Benjamin_Morgan
{
    [Serializable()]
    class Partido
    {
        private Equipo equipo1 { get; set; }
        private Equipo equipo2 { get; set; }
        private string resultado { get; set; }


        public Partido()
        {
            // aqui se ingresan los equipos que participan en el partido y el resultado sale de manera aleatoria (numero de goles de cada equipo es un random entre 0 y 3), usa corroborar para que no se genere un partido con equipos de tipos distintos
        }

        public void simular()
        {
            //simula el partido, genera el resultado, solo permite ser ejecutado 1 vez por objeto (solo si el resultado es vacio), si alguien se lesiona acciona el evento de curar al jugador o de cambiarlo
        }

        public void corroborar()  
        {
            // revisa que ambos equipos sean de liga o nacionales pero no mezclados
        }
        public void info()
        {
            //muestra la informacion de los equipos, cada uno de sus jugadores, cuanto duro el partido, el resultado y si fue nacional o de liga
        }
        public void Guardar_Partido()
        {
            //serializa los partidos
        }
        public void Cargar_Partido()
        {
            // desserializa los partidos de antes
        }
    }
}
