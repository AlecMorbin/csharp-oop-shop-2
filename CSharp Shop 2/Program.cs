using CSharp_Shop_2;

Aqcua acqua = new Aqcua("Sant'Anna","Bottiglia di acqua",1.23f,0.4f, 1.6f );

Console.WriteLine( acqua.ToString());

Console.WriteLine(acqua.getQuantity());

acqua.bevi(3);

Console.WriteLine(acqua.getQuantity());

acqua.svuota();

Console.WriteLine(acqua.getQuantity());

acqua.riempi(1.6f);
acqua.riempi(1.5f);


acqua.convertiGalloni();
