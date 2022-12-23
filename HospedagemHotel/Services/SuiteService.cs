using HospedagemHotel.Models;

namespace HospedagemHotel.Services
{
    public class SuiteService
    {
        public Suite? CriarSuite()
        {
            Console.Clear();
            Console.WriteLine("--- Cadastro de Suite ---"); 
            
            try
            {
                string tipoSuite = string.Empty; 
                int capacidade = 0;
                decimal valorDiaria = 0;

                Console.Write("Informe o tipo da suite: ");
                tipoSuite = Console.ReadLine(); 
                
                Console.Write("Informe a capacidade: ");
                var capacidadeTry = int.TryParse(Console.ReadLine(), out capacidade);

                if (!capacidadeTry)
                    throw new Exception("Informe um valor válido(inteiro) para capacidade da suite");

                Console.Write("Informe o valor da diaria: ");
                var valorDiariaTry = decimal.TryParse(Console.ReadLine(), out valorDiaria); 

                if (!valorDiariaTry)
                    throw new Exception("Informe um valor válido(decimal) para o valor diário da suite");
                
                return new Suite(tipoSuite, capacidade, valorDiaria);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Erro na execução: {ex.Message}");
            }

            return null;
        }
    }
}