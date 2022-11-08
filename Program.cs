using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "01", modelo: "N3420", imei: "983798713", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Microsoft Teams");
Console.WriteLine("...................................");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "02", modelo: "IPHONE 11", imei: "4535462246", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("...................................");
