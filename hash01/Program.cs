using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace hash01
{
   
    class Program
    {
        static void Main(string[] args)
        {
            String textIn = null;
            Console.Write("Entra text: ");
            while (textIn==null)
                textIn = Console.ReadLine();

            // Convertimos el string a una array de bytes
            byte[] bytesIn = UTF8Encoding.UTF8.GetBytes(textIn);
            // Instanciar classe para hacer el hash
            SHA512Managed SHA512 = new SHA512Managed();
            // Calcular hash
            byte[] hashResult = SHA512.ComputeHash(bytesIn);

            // Si queremos mostrar el hash por pantalla o guardarlo en un archivo de texto hace falta convertirlo a un string

            String textOut = BitConverter.ToString(hashResult, 0);
            Console.WriteLine("Hash {0}", textOut);
            Console.ReadKey();

            // Eliminamos la clase creada para liberar memoria
            SHA512.Dispose();
        }
    }
}
