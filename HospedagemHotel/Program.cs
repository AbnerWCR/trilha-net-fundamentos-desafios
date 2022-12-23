using HospedagemHotel.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var suiteService = new SuiteService();
        var pessoaService = new PessoaService();
        var reservaService = new ReservaService(pessoaService, suiteService);

        Console.Clear();
        Console.WriteLine("-------------------------------------------" +
                        "\n--- Bem vindo ao cadastro de Hospedagem ---" +
                        "\n-------------------------------------------");

        Console.WriteLine("\nDeseja cadastrar uma hospedagem? 1-Sim; 0-Nao");
        var decisao = Convert.ToBoolean(int.Parse(Console.ReadLine()));

        if (decisao)
        {
            var reserva = reservaService.CriarReserva();
            reservaService.RelatorioReserva(reserva);
        }

        Console.WriteLine("OK. Encerrando o sistema.......");
    }
}