using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{

    /*
     Encupsilation : Nesnenin üyelerine yapılan erişim kontrol altına alınmasına ve bu kontrolün nesnenin kendisi tarafından yapılmasını sağlamaktır. Amaç field'ları private yaparak bu alanlara dışarıdan erişimi önlemek ve get-set methodları ile kontrolü sağlamaktır.
     
     */
    public class Product
    {
        // Eğer ki bir değişkene erişim belirteci verilmezse default'u private'dır.
        int _id;
        string _name;
        double _price;

        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public string Name {
            get => _name;
            set => _name = value; }
        public double Price { 
            get => _price;
            set
            {
                if (value < 0)
                    Console.WriteLine("Fiyat Negatif Olamaz");
                else
                    _price = value;
            }

        }
    }
}
