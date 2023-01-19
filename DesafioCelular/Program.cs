using DesafioCelular.Services;
using DesafioCelular.Factories;
using DesafioCelular.Enum;

var factory = new SmartphoneFactory();

var serviceNokia = new SmartphoneService(factory, SmartphoneType.Nokia);
serviceNokia.CriarSmartphone();
serviceNokia.TestarSmartphone();
serviceNokia.InstalarAplicativo();

var serviceIphone = new SmartphoneService(factory, SmartphoneType.Iphone);
serviceIphone.CriarSmartphone();
serviceIphone.TestarSmartphone();
serviceIphone.InstalarAplicativo();
