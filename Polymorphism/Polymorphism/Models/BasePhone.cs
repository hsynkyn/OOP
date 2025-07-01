using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class BasePhone
    {
        // using : İçeriisinde kullandığınız nesnenin Garbage Collector tarafından temizlenmesini engeller. Kullanımı bittikten sonra kendi RAM'den siler.
        // Environment.CurrentDirectory : Proje dosyasındaki bin\debug\net8.0 klasörünün yolunu verir.
        // SoundPlayer : Verilen konumdaki müziği konsolda oynatmaya yarar.
        // NOT: using System.Media paketi kurulmadan kullanılamaz!!!
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\Sounds\default.wav"))
            {
                player.PlaySync();
            }

        }
    }
}
