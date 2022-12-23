using HospedagemHotel.Models;

namespace HospedagemHotel.Services
{
    public class PessoaService
    {
        public Pessoa? CriarPessoa()
        {
            Console.Clear();
            Console.WriteLine("--- Cadastro de Pessoa ---"); 
            
            try
            {
                string nome = string.Empty; 
                string sobrenome = string.Empty; 

                Console.Write("Informe o nome da pessoa: ");
                nome = Console.ReadLine(); 
                
                Console.Write("Informe o sobrenome da pessoa: ");
                sobrenome = Console.ReadLine(); 

                return new Pessoa(nome, sobrenome);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro na execução: {ex.Message}");
            } 

            return null;
        }
    }
}