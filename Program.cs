using System;

namespace ejercicio9PostEXT3
{

	class Program
	{
		static DateTime fechaHoy = DateTime.Now;
		static string rutaFichero = $"C:\\Users\\csi23-mserina\\Desktop\\{fechaHoy.ToString("ddMMyyyy")}.txt";


        static private void  vocalesCambiadas(string frase)
		{
			char cacater;
            char[] fraseArray = frase.ToCharArray();
            Char[]listaChar = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
			for(int i = 0; i < fraseArray.Length; i++)
			{
				for (int j = 0; j < listaChar.Length; j++)
				{
                    if (fraseArray[i] == listaChar[j])
                    {
						fraseArray[i] = '*';
					
                    }
               
                }
			}
            Console.WriteLine(fraseArray);
        }

		public static void Main(string[] args)
		{

			 
          //Solicita al usuario ingresar una frase por consola y luego reemplaza todas las vocales por el carácter '*'.
			Console.WriteLine("Inserte una frase");
			string palabrasEspacios;
			string frase = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Vocales sustituidas");
            vocalesCambiadas(frase);
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
					
                    sw.WriteLine (palabrasEspacios = palabras);
					
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
                    lineaActual = sr.ReadLine();
                    lineaAnterior = lineaActual;
                }

                // Muestra las dos últimas líneas
                Console.WriteLine("Dos últimas líneas del fichero:");
                Console.Write(lineaAnterior);
                Console.Write(lineaActual);
            }




        }
    }
}