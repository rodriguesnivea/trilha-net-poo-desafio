using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "(27) 98693-4219", modelo: "C01 Plus", imei: "35820277", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "(81) 99974-2173", modelo: "iPhone 15 Pro Max", imei: "67994426", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Linkedin");