using System;
using System.Diagnostics;

namespace ejercicio9PostEXT3
{

	class Program
	{
		static DateTime fechaHoy = DateTime.Now;
		static string rutaFichero = $"C:\\Users\\csi23-mserina\\Desktop\\{fechaHoy.ToString("ddMMyyyy")}.txt";


        static private string vocalesCambiadas(string frase)
		{
            int numeroDeVocales;
            char cacater;
            char[] fraseArray = frase.ToCharArray();
            Char[]listaChar = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
			for(int i = 0; i < fraseArray.Length; i++)
			{
				for (int j = 0; j < listaChar.Length; j++)
				{
                    if (fraseArray[i] == listaChar[j])
                    {
						int array = fraseArray[i] = '*';					
                    }
               
                }
			}
            string fraseModificada = new string(fraseArray);
            
            return fraseModificada;
        }

       static private void ficheroFuncion(string frase)
        {
            string palabrasEspacios;
            //Guarda la frase en una lista en la que cada celda contenta un "trozo" de la frase. La frase se dividirá por el carácter " ".
            string[] palabraArray = frase.Split(' ');
            //Escribe en un fichero la lista que contiene la frase. Cada celda en una línea diferente del fichero. El nombre del fichero tendrá el formato: ddMMyyyy.txt
            foreach (string palabras in palabraArray)
            {
                palabrasEspacios = palabras;
            }
            using (StreamWriter sw = new StreamWriter(rutaFichero))
            {
                foreach (string palabras in palabraArray)
                {

                    sw.WriteLine(palabrasEspacios = palabras);

                }
            }
            Console.WriteLine(" ");

             //Lee las dos últimas filas del fichero y muéstralas por consola en una sola línea.
            using (StreamReader sr = new StreamReader(rutaFichero))
            {
                string lineaAnterior = "AAA";
                string lineaActual = "AAAA";

                // Lee las líneas del archivo hasta el final, con EndofString nos pasa un valor boolean en funcion de si la posicion esta al final del fichero
                while (!sr.EndOfStream)
                {
                    // Guarda la línea anterior antes de leer la siguiente

                    lineaAnterior = lineaActual;
                    lineaActual = sr.ReadLine();
                }

                // Muestra las dos últimas líneas
                Console.WriteLine("Dos últimas líneas del fichero:");
                Console.Write(lineaAnterior + " ");
                Console.Write(lineaActual);
            }

        }

        static void sustituirVocalesFaltantes(string frase)
        {
            //Pregunta al usuario cuántas vocales faltan.
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("¿Cuantas lineas faltan?");
            int respuestaUsuario = Convert.ToInt32(Console.ReadLine());
            string palabraVocalesCensuradas = vocalesCambiadas(frase);
            int asteriscos = 0;
            char[] arrayPalabraCensurada = palabraVocalesCensuradas.ToCharArray();

            //PARA CONTAR LOS ASTERISCOS EN LA FRASE
            for (int i = 0; i < arrayPalabraCensurada.Length; i++)
            {
                if (arrayPalabraCensurada[i] == '*')
                {
                    asteriscos++;
                }
            }

            //PARA CAMBAIR LOS ASTERISCOS POR LAS VOCALES QUE INSERRTEN LOS USUARIOS
            if (asteriscos == respuestaUsuario)
            {
                for (int j = 0; j < arrayPalabraCensurada.Length - 1; j++)
                {
                    if (arrayPalabraCensurada[j] == '*')
                    {
                        Console.WriteLine("Introduzca la vocal faltante");
                        char vocales = Convert.ToChar(Console.ReadLine());
                        arrayPalabraCensurada[j] = vocales;
                    }
                }
            }

            string fraseFinal = new string(arrayPalabraCensurada);
            Console.WriteLine(" ");
            Console.WriteLine(fraseFinal);
        }

        public static void Main(string[] args)
		{

			 
          //Solicita al usuario ingresar una frase por consola y luego reemplaza todas las vocales por el carácter '*'.
			Console.WriteLine("Inserte una frase");
			
			string frase = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Vocales sustituidas");
            string fraseCensurada = vocalesCambiadas(frase);
            Console.WriteLine(fraseCensurada);

            ficheroFuncion(frase);

            sustituirVocalesFaltantes(frase);
           

            



        }
    }
}