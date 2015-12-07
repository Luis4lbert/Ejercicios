using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cliente 
    {

        private string nombre;
        private int monto;

        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }

        public void Depositar(int m){
            monto = monto + m;

        }

        public void Retirar(int m)
        {
            monto = monto - m;
        }

        public int Retornar_monto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.Write(nombre + "Tienes depositado la suma de :" + monto);
        }

        class Banco{
            private Cliente cliente1, cliente2, cliente3;

            cliente1 = new Cliente("Luis");
        }
        static void Main(string[] args)
        {
        }
    }
}
