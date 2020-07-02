using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace exmanen_poo_Benjamin_Morgan
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;

            while (opcion != 9)
            {
                //en el menu solo pongo las opciones que se prueban para que no se generen caidas con partes no programadas
                Console.WriteLine("que desea hacer en el programa?");
                Console.WriteLine("1) Crear un equipo");
                Console.WriteLine("2) Ver informacion de un equipo");
                Console.WriteLine("3) Ver nacionalidad de los integrantes de un equipo");
                Console.WriteLine("9) salir del programa");
                string Numerodelusuario = Console.ReadLine() ;
                Int32.TryParse(Numerodelusuario, out opcion);
                Equipo saveEquipos = new Equipo();
                saveEquipos.Cargar_Equipos();
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("ingrese el nombre del equipo a crear");
                            string nombreteam = Console.ReadLine(); 
                            List<Persona> EquipoACrear = new List<Persona>();
                            // cada equipo tiene un medico, un entrenador y 15 jugadores, por lo que se crearan en ese orden y obligando a que almenos un jugador sea arquero
                            Console.WriteLine("cada equipo tiene un medico, entrenador y 15 jugadores, iniciemos creando al medico");
                            Console.WriteLine("cual es el nombre del medico?");
                            string nombremedico = Console.ReadLine();
                            Console.WriteLine("cual es la nacionalidad del medico?");
                            string nacionmedico = Console.ReadLine();
                            Console.WriteLine("edad del medico?");
                            string RespEdadMedico = Console.ReadLine();
                            int edadmedico; 
                            Int32.TryParse(RespEdadMedico, out edadmedico);
                            while(edadmedico == 0)
                            {
                                Console.WriteLine("ingrese un numero valido");
                                RespEdadMedico = Console.ReadLine();
                                Int32.TryParse(RespEdadMedico, out edadmedico);
                            }

                            Console.WriteLine("sueldo del medico?");
                            string RespSueldoMedico = Console.ReadLine();
                            int sueldomedico;
                            Int32.TryParse(RespSueldoMedico, out sueldomedico);
                            while (sueldomedico == 0)
                            {
                                Console.WriteLine("ingrese un numero valido");
                                RespSueldoMedico = Console.ReadLine();
                                Int32.TryParse(RespSueldoMedico, out sueldomedico);
                            }

                            Console.WriteLine("cuanta experencia del medico?");
                            string RespexpMedico = Console.ReadLine();
                            int experenciadelmedico;
                            Int32.TryParse(RespexpMedico, out experenciadelmedico);
                            while (experenciadelmedico == 0)
                            {
                                Console.WriteLine("ingrese un numero valido");
                                RespexpMedico = Console.ReadLine();
                                Int32.TryParse(RespexpMedico, out experenciadelmedico);
                            }
                            Medico MedicoDelEquipo = new Medico(nombremedico,nacionmedico,edadmedico,sueldomedico,experenciadelmedico);
                            EquipoACrear.Add(MedicoDelEquipo);
                            Console.WriteLine("Medico creado con exito");
                            Thread.Sleep(2000);
                            Console.Clear();
                            //###########################################################################################
                            Console.WriteLine("ahora creemos al entrenador del equipo");
                            Console.WriteLine("cual es el nombre del entrenador?");
                            string nombreEntrenador = Console.ReadLine();
                            Console.WriteLine("cual es la nacionalidad del entrenador?");
                            string nacionEntrenador = Console.ReadLine();
                            Console.WriteLine("edad del entrenador?");
                            string RespEdadEntrenador = Console.ReadLine();
                            int edadEntrenador;
                            Int32.TryParse(RespEdadEntrenador, out edadEntrenador);
                            while (edadEntrenador == 0)
                            {
                                Console.WriteLine("ingrese un numero valido");
                                RespEdadEntrenador = Console.ReadLine();
                                Int32.TryParse(RespEdadEntrenador, out edadEntrenador);
                            }

                            Console.WriteLine("sueldo del entrenador?");
                            string RespSueldoEntrenador = Console.ReadLine();
                            int sueldoEntrenador;
                            Int32.TryParse(RespSueldoEntrenador, out sueldoEntrenador);
                            while (sueldoEntrenador == 0)
                            {
                                Console.WriteLine("ingrese un numero valido");
                                RespSueldoEntrenador = Console.ReadLine();
                                Int32.TryParse(RespSueldoEntrenador, out sueldoEntrenador);
                            }

                            Console.WriteLine("experencia tactica del entrenador?");
                            string RespexpEntrenador = Console.ReadLine();
                            int experenciaEntrenador;
                            Int32.TryParse(RespexpEntrenador, out experenciaEntrenador);
                            while (experenciaEntrenador == 0)
                            {
                                Console.WriteLine("ingrese un numero valido");
                                RespexpEntrenador = Console.ReadLine();
                                Int32.TryParse(RespexpEntrenador, out experenciaEntrenador);
                            }
                            Entrenador EntrenadorDelEquipo = new Entrenador(nombreEntrenador,nacionEntrenador,edadEntrenador,sueldoEntrenador,experenciaEntrenador);
                            EquipoACrear.Add(EntrenadorDelEquipo);
                            Console.WriteLine("entrenador creado con exito");
                            Thread.Sleep(2000);
                            Console.Clear();
                            //#########################################################
                            for (int i = 0; i < 15; i++)
                            {
                                Console.WriteLine("jugador numero: " + (i+1));
                                if (i == 0)
                                    Console.WriteLine("partamos por crear al arquero");
                                if (i != 0)
                                    Console.WriteLine("creamos al siguiente jugador");
                                Console.WriteLine("ingrese el nombre del jugador");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("ingrese la nacionalidad del jugador");
                                string nacionalidad = Console.ReadLine();
                                nacionalidad.ToLower();

                                Console.WriteLine("edad del jugador?");
                                string Respedadjugador = Console.ReadLine();
                                int edadjugador;
                                Int32.TryParse(Respedadjugador, out edadjugador);
                                while (edadjugador == 0)
                                {
                                    Console.WriteLine("ingrese un numero valido");
                                    Respedadjugador = Console.ReadLine();
                                    Int32.TryParse(Respedadjugador, out edadjugador);
                                }

                                Console.WriteLine("sueldo del jugador?");
                                string Respsueldojugador = Console.ReadLine();
                                int sueldojugador;
                                Int32.TryParse(Respsueldojugador, out sueldojugador);
                                while (sueldojugador == 0)
                                {
                                    Console.WriteLine("ingrese un numero valido");
                                    Respsueldojugador = Console.ReadLine();
                                    Int32.TryParse(Respsueldojugador, out sueldojugador);
                                }

                                string posicion;
                                if (i == 0)
                                    posicion = "Arquero";
                                else
                                    posicion = "Jugador";

                                Console.WriteLine("puntos de atake del jugador?");
                                string Respatakejugador = Console.ReadLine();
                                int atakejugador;
                                Int32.TryParse(Respatakejugador, out atakejugador);
                                while (atakejugador == 0)
                                {
                                    Console.WriteLine("ingrese un numero valido");
                                    Respatakejugador = Console.ReadLine();
                                    Int32.TryParse(Respatakejugador, out atakejugador);
                                }

                                Console.WriteLine("defensa del jugador?");
                                string Respdefjugador = Console.ReadLine();
                                int defensajugador;
                                Int32.TryParse(Respdefjugador, out defensajugador);
                                while (defensajugador == 0)
                                {
                                    Console.WriteLine("ingrese un numero valido");
                                    Respdefjugador = Console.ReadLine();
                                    Int32.TryParse(Respdefjugador, out defensajugador);
                                }

                                Console.WriteLine("Numero de camiseta del jugador?");
                                string Respnumerojugador = Console.ReadLine();
                                int numerojugador;
                                Int32.TryParse(Respnumerojugador, out numerojugador);
                                while (numerojugador == 0)
                                {
                                    Console.WriteLine("ingrese un numero valido");
                                    Respnumerojugador = Console.ReadLine();
                                    Int32.TryParse(Respnumerojugador, out numerojugador);
                                }

                                int salud = 100; // todos los jugadores parten en perfecto estado

                                Jugador nuevojugador = new Jugador(nombre,nacionalidad,edadjugador,sueldojugador,atakejugador,defensajugador,numerojugador,salud,posicion);
                                EquipoACrear.Add(nuevojugador);

                                Console.Clear();
                            }

                            Equipo equipocreado = new Equipo(EquipoACrear, nombreteam);
                            Console.WriteLine("Equipo creado con exito");
                            saveEquipos.AgregarEquipoAlSistema(equipocreado);
                            saveEquipos.Guardar_Equipos();
                            Thread.Sleep(2000);
                            Console.Clear();

                            break;
                        }
                    case 2:
                        {
                            if(saveEquipos.ObtenerListaEquipos().Count != 0)
                            {
                                Console.WriteLine("de que equipo quiere ver la informacion");
                                for (int i = 0; i < saveEquipos.ObtenerListaEquipos().Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ") " + saveEquipos.ObtenerListaEquipos()[i].get_nombre());
                                }
                                string Resp = Console.ReadLine();
                                int equipoelegido;
                                Int32.TryParse(Resp, out equipoelegido);
                                while (equipoelegido == 0 && equipoelegido < saveEquipos.ObtenerListaEquipos().Count)
                                {
                                    Console.WriteLine("ingrese un numero valido");
                                    Resp = Console.ReadLine();
                                    Int32.TryParse(Resp, out equipoelegido);
                                }
                                saveEquipos.ObtenerListaEquipos()[equipoelegido - 1].Informacion_Del_Equipo();

                                Thread.Sleep(5000);
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("no hay equipos en el sistema");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }



                            break;
                        }
                    case 3:
                        {
                            if (saveEquipos.ObtenerListaEquipos().Count != 0)
                            {
                                Console.WriteLine("de que equipo quiere verificar la nacionalidad de sus jugadores");
                                for (int i = 0; i < saveEquipos.ObtenerListaEquipos().Count; i++)
                                {
                                    Console.WriteLine(i + 1 + ") " + saveEquipos.ObtenerListaEquipos()[i].get_nombre());
                                }
                                string Resp = Console.ReadLine();
                                int equipoelegido;
                                Int32.TryParse(Resp, out equipoelegido);
                                while (equipoelegido == 0 && equipoelegido < saveEquipos.ObtenerListaEquipos().Count)
                                {
                                    Console.WriteLine("ingrese un numero valido");
                                    Resp = Console.ReadLine();
                                    Int32.TryParse(Resp, out equipoelegido);
                                }
                                if(saveEquipos.ObtenerListaEquipos()[equipoelegido - 1].verificar_nacionalidad_jugadores())
                                {

                                }
                                else
                                {
                                    Console.WriteLine("no todos los jugadores tienen la misma nacionalidad");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                            }
                            else
                            {
                                Console.WriteLine("no hay equipos en el sistema");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }


                            break;
                        }
                    case 9:
                        {
                            opcion = 9;
                            break;
                        }
                    default:
                        Console.WriteLine("opcion no valida, ingrese un numero valido");
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            }

        }
    }
}
