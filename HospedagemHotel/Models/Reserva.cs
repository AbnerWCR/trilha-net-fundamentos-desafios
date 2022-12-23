namespace HospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; private set; }
        public Suite Suite { get; private set; }
        public int DiasReservados { get; private set; }
        public decimal ValorDiaria => CalcularValorDiaria();
        public int QtdHospedes => Hospedes.Count();

        public Reserva(int qtdDias, Suite suite)
        {
            DiasReservados = qtdDias;
            Suite = suite;
            Hospedes = new List<Pessoa>();
        } 

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
             if (Suite.Capacidade < hospedes.Count())
                    throw new Exception("A capacidade da suite não atende a quantidade de hospedes.");

            Hospedes = hospedes;
        }

        private decimal CalcularValorDiaria()
        {
            var diaria = Math.Round(DiasReservados * Suite.ValorDiaria, 2);
            var desconto = (decimal)0.9;

            if (DiasReservados >= 10)
                diaria = Math.Round(diaria * desconto, 2);
            
            return diaria;
        }

        private void Validar()
        {
            if (DiasReservados <= 0)
                throw new Exception("DiasReservados deve ter um valor(inteiro) válido.");
        }
    }
}