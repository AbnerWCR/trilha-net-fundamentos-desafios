using System;

namespace DesafioCelular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string iMEI, int memoria)
            : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string aplicativo)
        {
            ValidarAplicativo(aplicativo);

            Console.WriteLine("Instalando aplicativo no sistema Android...");
            Console.WriteLine("Instalação concluída :)");
        }
    }
}