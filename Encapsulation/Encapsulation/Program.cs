using Encapsulation.Models;

Product product = new Product();
product.Id = 1;
product.Name = "Eldiven";
product.Price = -45.46;


Console.WriteLine($"Id : {product.Id}\nAd: {product.Name}\nFiyat : {product.Price}");