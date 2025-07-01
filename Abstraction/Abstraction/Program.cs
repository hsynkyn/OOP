using Abstraction.Model;

Guitar guitar = new Guitar();
guitar.Name = "Gitar";
guitar.Brand = "Fender";
guitar.Description = "Çok Pahalı..";

Drums drums = new Drums();
drums.Name = "Bateri";
drums.Brand = "Yamaha";
drums.Description = "Pahalı";

Flute flute = new Flute();
flute.Name = "Flüt";
flute.Brand = "Demender";
flute.Description = "Az Pahalı";

//List<Instrument> instruments = new List<Instrument>() { guitar, flute,drums};

//foreach (Instrument instrument in instruments)
//{
//    Console.WriteLine($"Marka: {instrument.Brand}\nAçıklama: {instrument.Description}\nSesi: {instrument.Play()}\n============");
//}

Musician guitarist = new Musician();
guitarist.Name = "Hamza";
guitarist.Surname = "Gitarsoy";
guitarist.Instrument = guitar;

Musician drummer = new Musician();
drummer.Name = "Hamza";
drummer.Surname = "Baterisoy";
drummer.Instrument = drums;

Musician flutist = new Musician();
flutist.Name = "Hamza";
flutist.Surname = "Flutsoy";
flutist.Instrument = flute;

List<Musician> orchestra = new List<Musician>() { guitarist,drummer,flutist};

foreach (Musician musician in orchestra)
{
    Console.WriteLine($"Muzisyen: {musician.Name} {musician.Surname}\nÇaldığı Enstruman: {musician.Instrument.Name}\nMarkası: {musician.Instrument.Brand}\nAçıklaması: {musician.Instrument.Description}\nSesi: {musician.Instrument.Play()}\n====================");
}