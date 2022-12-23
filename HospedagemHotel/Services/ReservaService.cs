using HospedagemHotel.Models;

namespace HospedagemHotel.Services
{
    public class ReservaService
    {

        private readonly PessoaService _pessoaService;
        private readonly SuiteService _suiteService;

        public ReservaService(
            PessoaService pessoaService,
            SuiteService suiteService)
        {
            _pessoaService = pessoaService;
            _suiteService = suiteService;
        }

        public Reserva? CriarReserva()
        {
            Console.Clear();
            Console.WriteLine("--- Cadastro de Reserva ---");

            try
            {
                var suite = CriarSuite();
                var hospedes = CriarHospedes();
                int qtdDias = 0;

                Console.Write("Informe a quantidade de dias desejada: ");
                var qtdDiasTry = int.TryParse(Console.ReadLine(), out qtdDias);

                if (!qtdDiasTry)
                    throw new Exception("Informe um valor válido(inteiro) para a quantidade de dias.");
                    
                var reserva = new Reserva(qtdDias, suite);
                reserva.CadastrarHospedes(hospedes);

                return reserva;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução: {ex.Message}");
            }

            return null;
        }

        public void RelatorioReserva(Reserva? reserva)
        {
            if (reserva != null)
            {
                Console.WriteLine($"Hóspedes: {reserva.QtdHospedes}");
                Console.WriteLine($"Valor diária: {reserva.ValorDiaria}");
            }
        }

        private Suite CriarSuite()
        {
            var suite = _suiteService.CriarSuite();

            if (suite == null)
                throw new Exception("Ocorreu um erro na criação da suite");

            return suite;
        }

        private List<Pessoa> CriarHospedes()
        {
            var hospedes = new List<Pessoa>();
            var cadastroHospede = true;

            while (cadastroHospede)
            {
                var pessoa = _pessoaService.CriarPessoa();

                if (pessoa == null)
                    throw new Exception("Ocorreu um erro na criação da pessoa");

                hospedes.Add(pessoa);

                Console.WriteLine("Deseja cadastrar um novo hospede: 1-Sim 0-Não");
                cadastroHospede = Convert.ToBoolean(int.Parse(Console.ReadLine()));
            }

            return hospedes;
        }
    }
}