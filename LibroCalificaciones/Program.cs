using System;

namespace program
{
    public class PruebaLibroCalificaciones
    {
        public static void Main(string[] args)
        {
            LibroCalificaciones miLibroCalificaciones =
                new LibroCalificaciones(
                    "CS101 Introducción a la programación en C#"
                );

            miLibroCalificaciones.MostrarMensaje();
            miLibroCalificaciones.DeterminarPromedioClase();
        }
    }
}