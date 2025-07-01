using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Model
{

    /*
     Abstract Classlar
    Sadece base class olarak davranmasını (yani inherit edilmesi) ve kendisinde instance çıkartılmaması istediğimiz durumlarda kullanılır. Bir sınıf abstract (soyut) olarak işaretlendiğinde, bu sınıfın kendisinden direkt nesne oluşturulamaz. Yani, new AbstractClass() şeklinde bir nesne oluşturulamaz. Soyut sınıflar yalnızca türetilen (inherited) sınıflara temel sağlamak amacıyla kullanılır.
     
     */
    public abstract class Instrument
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }

        public abstract string Play();
    }
}
