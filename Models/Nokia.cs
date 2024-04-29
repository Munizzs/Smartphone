using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioSmatphone.Models;

namespace ExercicioSmartphone.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string num) : base(num)
        {
        }

        public override void InstalarApp(string nome)
        {
            Console.WriteLine($"Instalando {nome} atravez da Play Store");
        }
    }
}