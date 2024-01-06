using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1122334455", modelo: "Modelo 1", imei: "6677889900", memoria: 123);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone Iphone: ");
Smartphone iphone = new Iphone(numero: "5544332211", modelo: "Modelo 2", imei: "0099887766", memoria: 456);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");