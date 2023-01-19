using System;

namespace DesafioCelular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria)
            : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            ValidarAplicativo(aplicativo);

            Console.WriteLine("Instalando aplicativo no sistema IOS...");
            Console.WriteLine("Instalação concluída :)");
        }
    }
}