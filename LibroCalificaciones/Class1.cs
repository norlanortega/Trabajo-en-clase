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
                "Bienvenido al libro de calificaciones para "
                + NombreCurso);
        }

        public void DeterminarPromedioClase()
        {
            int total = 0;
            int contadorCalif = 1;
            int calificacion;
            double promedio;

            while (contadorCalif <= 10)
            {
                Console.Write("Escriba la calificación: ");
                calificacion = Convert.ToInt32(Console.ReadLine());

                total = total + calificacion;
                contadorCalif = contadorCalif + 1;
            }

            promedio = (double)total / 10;

            Console.WriteLine(
                "El total de las calificaciones es {0}", total
            );

            Console.WriteLine(
                "El promedio de la clase es {0}", promedio
            );
        }
    }
}