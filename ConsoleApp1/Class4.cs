
using System;

namespace program
{
    public class LibroCalificaciones
    {
        private string nombreCurso;


        public LibroCalificaciones(string nombre)
        {
            nombreCurso = nombre;
        }


        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }

            set
            {
                nombreCurso = value;
            }
        }


        public void MostrarMensaje()
        {
            Console.WriteLine(
                "Bienvenido al libro de calificaciones para " + NombreCurso
            );
        }


        public void DeterminarPromedioClase()
        {
            int total;
            int contadorCalif;
            int calificacion;
            double promedio;

            total = 0;
            contadorCalif = 0;

            Console.Write("Escriba la calificación o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());

            while (calificacion != -1)
            {
                total += calificacion;
                contadorCalif++;

                Console.Write("Escriba la calificación o -1 para salir: ");
                calificacion = Convert.ToInt32(Console.ReadLine());
            }

            if (contadorCalif > 0)
            {
                promedio = (double)total / contadorCalif;

                Console.WriteLine(
                    "El total de las calificaciones es {0}", total
                );

                Console.WriteLine(
                    "El promedio de la clase es {0}", promedio
                );
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }
        }
    }
}