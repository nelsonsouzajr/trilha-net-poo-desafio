using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Concluido

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("11111111111", "Modelo 1", "999999999", 64 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo( "Discord" );

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("99999999999", "Modelo 2", "111111111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("Mail");