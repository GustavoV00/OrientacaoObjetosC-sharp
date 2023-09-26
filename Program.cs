// See https://aka.ms/new-console-template for more information
using CelularPOO.Models;

Iphone iphone = new Iphone("numero", "iphone", "imei", "memoria");
Nokia nokia = new Nokia("numero", "nokia", "imei", "memoria");

iphone.InstalarAplicativo("facebook");
nokia.InstalarAplicativo("instagram");

iphone.Ligar();
nokia.Ligar();

iphone.ReceberLigacao();
nokia.ReceberLigacao();