using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia a57 = new Nokia(numero: "1213727", modelo: "a57", imei: "654654654", memoria: 256);
Iphone promax12 = new Iphone(numero: "1213727", modelo: "12 promax", imei: "654654654", memoria: 256);

a57.Ligar();
a57.ReceberLigacao();

a57.InstalarAplicativo(nomeApp: "Instagram");

promax12.Ligar();
promax12.ReceberLigacao();

promax12.InstalarAplicativo(nomeApp: "Instagram");