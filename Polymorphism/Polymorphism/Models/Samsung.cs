﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Samsung : BasePhone
    {
        public override void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\Sounds\samsung.wav"))
            {
                player.PlaySync();            
            }
        }
    }
}
