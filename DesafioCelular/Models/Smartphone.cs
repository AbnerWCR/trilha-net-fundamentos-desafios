using System;

namespace DesafioCelular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; private set; }
        protected string Modelo { get; private set; }
        protected string IMEI { get; private set; }
        protected int Memoria { get; private set; }

        public Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
            Validar();
        }

        public void AlterarNumero(string numero)
        {
            Numero = numero;
            Validar();
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string aplicativo);

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(Numero))
                throw new Exception("Número do smartphone é inválido");

            if (string.IsNullOrEmpty(Modelo))
                throw new Exception("Modelo do smartphone é inválido");

            if (string.IsNullOrEmpty(IMEI))
                throw new Exception("IMEI do smartphone é inválido");

            if (Memoria <= 0)
                throw new Exception("Memoria do smartphone é inválida");
        }

        public virtual void ValidarAplicativo(string aplicativo)
        {
             if (string.IsNullOrEmpty(aplicativo))
                throw new Exception($"Aplicativo: {aplicativo}; é inválido");
        }
    }
}