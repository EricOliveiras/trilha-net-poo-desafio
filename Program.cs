using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new("988221122", "Nokia tijolão", "AEI12345", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new("988221122", "iphone 4", "AEI9876", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");