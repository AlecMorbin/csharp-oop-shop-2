using CSharp_Shop_2;

Aqcua acqua = new Aqcua("Sant'Anna","Bottiglia di acqua",1.23f,0.4f, 1.6f );

Console.WriteLine( acqua.ToString());

Console.WriteLine(acqua.getQuantity());

acqua.bevi(3);

Console.WriteLine(acqua.getQuantity());

acqua.svuota();

Console.WriteLine(acqua.getQuantity());

try
{
    acqua.riempi(1.6f);
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}
acqua.riempi(1.5f);


acqua.convertiGalloni();

SacchetoFrutta saccheto = new SacchetoFrutta("Spesa", "Dal fruttivendolo", 3.4f, 0.4f);

saccheto.inserisciFrutta("mela");
saccheto.inserisciFrutta("pera");
saccheto.inserisciFrutta("uva");
saccheto.inserisciFrutta("fragole");
saccheto.inserisciFrutta("uvetta");

Console.WriteLine(saccheto.getPezzi());

saccheto.rimuoviFrutto("mela");

Console.WriteLine(saccheto.getPezzi());

saccheto.rimuoviFrutto("kiwi");

Console.WriteLine(saccheto.getPezzi());
