namespace Ejercicio9repasoStrings
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Escriba una cadena de texto");
            string cadenaOriginal = Console.ReadLine();

            //Remplazar vocales por: *
            string cadenaVocalesModificadas = remplazoVocales(cadenaOriginal);
            Console.WriteLine(cadenaVocalesModificadas);

            /* Guarda la frase en una lista en la que 
             * cada celda contenta un "trozo" de la frase.
             * La frase se dividirá por el carácter " ".*/
            particionEnTrozosYCreacionFichero(cadenaVocalesModificadas);

            contarVocalesYCorregirlas(cadenaVocalesModificadas);
        }


        private static string remplazoVocales(string texto)
        {
            string textoCambiado = texto.Replace('a', '*').Replace('e', '*').Replace('i', '*').Replace('o', '*').Replace('u', '*');
            return textoCambiado;
        }

        private static void particionEnTrozosYCreacionFichero(string cadenaModificada)
        {
            string[] cadenaEnTrozos = cadenaModificada.Split(' ');
            //Console.WriteLine();
            DateTime fechaDate = DateTime.Now;
            string fecha = fechaDate.ToString("ddMMyyyy");
            StreamWriter sw = new StreamWriter(fecha + ".txt");
            for (int i = 0; i < cadenaEnTrozos.Length; i++)
            {
                sw.WriteLine(cadenaEnTrozos[i]);
            }

            Console.WriteLine(cadenaEnTrozos[cadenaEnTrozos.Length - 1] + cadenaEnTrozos[cadenaEnTrozos.Length - 2]);
        }

        private static void contarVocalesYCorregirlas(string cadenaVocalesModificadas)
        {
            string fraseCambiadaVocalesDadas = "";
            int contadarDeVocalesMalas = 0;
            Console.WriteLine("¿cuántas vocales faltan?");
            int vocalesQueFaltan = int.Parse(Console.ReadLine());
            for (int i = 0; i < cadenaVocalesModificadas.Length - 1; i++)
            {
                if (cadenaVocalesModificadas[i].Equals('*'))
                {
                    contadarDeVocalesMalas++;
                }
                if (contadarDeVocalesMalas == vocalesQueFaltan)
                {
                    for (int j = 0; j < cadenaVocalesModificadas.Length - 1; j++)
                    {
                        Console.Write(cadenaVocalesModificadas[j]);
                        if (cadenaVocalesModificadas[j].Equals('*'))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Que vocal va aqui");
                            char vocalBuena = char.Parse(Console.ReadLine());

                            
                        }
                    }
                }
            }

        }
    }
}
