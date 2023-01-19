using DesafioCelular.Models;
using DesafioCelular.Enum;

namespace DesafioCelular.Factories
{
    public class SmartphoneFactory
    {
        public Smartphone CriarSmartphone(SmartphoneType type, string numero, string modelo, string iMEI, int memoria)
        {
            switch (type)
            {
                case SmartphoneType.Iphone:
                    return new Iphone(numero, modelo, iMEI, memoria);
                case SmartphoneType.Nokia:
                    return new Nokia(numero, modelo, iMEI, memoria);
                default:
                    throw new Exception("Invalid type smartphone");
            }
        }
    }
}