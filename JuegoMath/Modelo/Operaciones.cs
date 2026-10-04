using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoMath.Modelo
{
    internal abstract class Operaciones
    {
        protected static Random rand = new Random();

        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public int respuestaCorrecta { get; set; }

        public void Pregunta()
        {
            numero1 = rand.Next(1, 11);
            numero2 = rand.Next(1, 11);
            GenerarRespuesta();
            MostrarEnunciado();
        }

        protected abstract void MostrarEnunciado();
        protected abstract void GenerarRespuesta();
    }

    internal class Suma : Operaciones
    {
        protected override void MostrarEnunciado()
        {
            Console.WriteLine($"{numero1} + {numero2} = ?");
        }

        protected override void GenerarRespuesta()
        {
            respuestaCorrecta = numero1 + numero2;
        }
    }


    internal class Resta : Operaciones
    {
        protected override void MostrarEnunciado()
        {
            Console.WriteLine($"{numero1} - {numero2} = ?");
        }

        protected override void GenerarRespuesta()
        {
            respuestaCorrecta = numero1 - numero2;
        }
    }

    internal class Multi : Operaciones
    {
        protected override void MostrarEnunciado()
        {
            Console.WriteLine($"{numero1} x {numero2} = ?");
        }

        protected override void GenerarRespuesta()
        {
            respuestaCorrecta = numero1 * numero2;
        }
    }

    internal class Dividir : Operaciones
    {
        protected override void MostrarEnunciado()
        {
            Console.WriteLine($"{numero1} / {numero2} = ?");
        }

        protected override void GenerarRespuesta()
        {
            respuestaCorrecta = numero1 / numero2;
        }
    }

}
