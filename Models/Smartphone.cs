using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioSmatphone.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string modelo;
        private string IMEI;
        private int Memoria;

        protected Smartphone(string num)
        {
            Numero = num;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo Ligação...");
        }

        public abstract void InstalarApp(string nome);
    }
}