namespace HospedagemHotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; private set; }
        public int Capacidade { get; private set; }
        public decimal ValorDiaria { get; private set; }

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;

            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrEmpty(TipoSuite))
                throw new Exception("Nome deve ser preenchido.");

            if (Capacidade <= 0)
                throw new Exception("Capacidade deve ter um valor(inteiro) válido.");

            if (ValorDiaria <= 0)
                throw new Exception("Valor diaria deve ter um valor(real) válido");
        }
    }
}