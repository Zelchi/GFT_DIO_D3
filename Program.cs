using GFT_DIO_D3.Models;

Iphone celular1 = new(numero: "123123", modelo: "10S", imei: "Batata", memoria: 512);
Nokia celular2 = new(numero: "321321", modelo: "Edge 10", imei: "Frita", memoria: 256);

celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Facebook");

celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Instagram");