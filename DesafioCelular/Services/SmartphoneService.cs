using DesafioCelular.Models;
using DesafioCelular.Factories;
using DesafioCelular.Enum;

namespace DesafioCelular.Services
{
    public class SmartphoneService
    {
        private readonly SmartphoneFactory _factory;
        private readonly SmartphoneType _smartphoneType;
        private Smartphone? _smartphone;

        public SmartphoneService(SmartphoneFactory factory, SmartphoneType smartphoneType)
        {
            _factory = factory;
            _smartphoneType = smartphoneType;
        }

        public Smartphone CriarSmartphone()
        {            
            try
            {          
                Console.Clear();      
                Console.WriteLine($"Criando um smartphone do tipo {_smartphoneType}");

                Console.Write("\nInforme o número do smartphone: ");
                string numero = Console.ReadLine();

                Console.Write("\nInforme o modelo do smartphone: ");
                string modelo = Console.ReadLine();

                Console.Write("\nInforme o IMEI do smartphone: ");
                string iMEI = Console.ReadLine();

                Console.Write("\nInforme a memória do smartphone: ");
                int memoria = Convert.ToInt32(Console.ReadLine());

                _smartphone = _factory.CriarSmartphone(_smartphoneType, numero, modelo, iMEI, memoria);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return _smartphone;
        }

        public void TestarSmartphone()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Testando smartphone...");
                _smartphone.Ligar();
                _smartphone.ReceberLigacao();
            }
            catch
            {
                Console.WriteLine("Algo deu errado :(");
            }
        }

        public void InstalarAplicativo()
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Instalando um aplicativo no dispositivo {_smartphoneType}");

                Console.Write("\nDigite o nome do aplicativo: ");
                string aplicativo = Console.ReadLine();
                _smartphone.InstalarAplicativo(aplicativo);
            }
            catch
            {                
                Console.WriteLine("Algo deu errado :(");
            }
        }
    }
}