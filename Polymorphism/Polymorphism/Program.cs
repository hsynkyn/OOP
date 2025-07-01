using Polymorphism.Models;

BasePhone basePhone = new BasePhone();
basePhone.Brand = "None";
basePhone.Model = "-----";
basePhone.Price = 0;

IPhone iphone = new IPhone();
iphone.Brand = "IPhone";
iphone.Model = "16 Pro Max 256 GB";
iphone.Price = 95000;

Samsung samsung = new Samsung();
samsung.Brand = "Samsung";
samsung.Model = "S23 Ultra";
samsung.Price = 60000;

Nokia nokia = new Nokia();
nokia.Brand = "Nokia";
nokia.Model = "Lumia";
nokia.Price = 20000;

List<BasePhone> phones = new List<BasePhone>(){basePhone,iphone,samsung,nokia};

foreach(BasePhone phone in phones)
{
    Console.WriteLine($"Marka: {phone.Brand}\nModel: {phone.Model}\nFiyat: {phone.Price}\n================");
    phone.CallSound();
}

