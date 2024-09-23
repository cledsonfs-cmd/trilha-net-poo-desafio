using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("(85) 9999-9999","Nokia Plus","123456789",32);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("(85) 8888-8888","Iphone 12","987456321",128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegran");