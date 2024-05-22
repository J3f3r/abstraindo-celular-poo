using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone("16 9999 8888", "Pro 11", "1234", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.Desligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("11 9876 1234", "G21", "7654", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.Desligar();
nokia.InstalarAplicativo("Linkedin");
// TODO: Realizar os testes com as classes Nokia e Iphone