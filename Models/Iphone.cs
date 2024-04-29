using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercicioSmatphone.Models;

namespace ExercicioSmartphone.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string num) : base(num)
        {
        }

        public override void InstalarApp(string nome)
        {
            Console.WriteLine($"Instalando {nome} atravez da App Store");
        }
    }
}