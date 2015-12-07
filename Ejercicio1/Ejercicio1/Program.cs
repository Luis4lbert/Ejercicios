using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el Tamaño del arreglo: "); 
            String tam_array = Console.ReadLine();
            int tamanio = Int32.Parse(tam_array);

            Console.Write("Introduce la longitud del password");
            String lon_pass = Console.ReadLine();
            int longitud = Int32.Parse(lon_pass);

            Password lista_pass = new Password[tamanio];
            Boolean fortaleza_pass = new Boolean[tamanio];

            for(int i=0;i<lista_pass.length;i++){
            lista_pass[i]=new Password(longitud);
            fortaleza_pass[i] = lista_pass[i].esFuerte();
            Console.Write(lista_pass[i].getContraseña() + " " + fortaleza_pass[i]);
        }

        }
    }
}
