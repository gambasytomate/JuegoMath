using JuegoMath.Modelo;

public class Programs
{
    public static void Main(string[] args)
    {

        Random random = new Random();

        int numeroTOperacion = 0;
        int intentos = 5;
        int puntos = 0;
        bool correcto = false;
        int respuestaCorrecta1= 0;

        Suma suma = new Suma();
        Resta resta = new Resta();
        Multi multi = new Multi();
        Dividir divi = new Dividir();

        Console.WriteLine("BIENVENIDO!! RESPONDE A LAS SIGUIENTES PREGUNTAS");

        while (intentos != 0)
        {
            numeroTOperacion = random.Next(1, 4);

            switch (numeroTOperacion)
            {
                case 1:
                    suma.Pregunta();
                    respuestaCorrecta1 = suma.respuestaCorrecta;
                    break;
                case 2:
                    resta.Pregunta();
                    respuestaCorrecta1 = resta.respuestaCorrecta;
                    break;
                case 3:
                    multi.Pregunta();
                    respuestaCorrecta1 = multi.respuestaCorrecta;
                    break;
                case 4:
                    divi.Pregunta();
                    respuestaCorrecta1 = divi.respuestaCorrecta;
                    break;
            }

            int respuesta = int.Parse(Console.ReadLine());
            if (respuesta != respuestaCorrecta1)
            {
                puntos = puntos - 10;
            }
            else { 
                puntos = puntos +10;
            }

            intentos--;
        }

        System.Console.WriteLine($"Número de puntos: {puntos}");
    }
}
