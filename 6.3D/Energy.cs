﻿using SplashKitSDK;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3D
{
    public class Energy: Projectile
    {
        public Energy() : base()
        {
            Bitmap = new Bitmap("Energy", "energy.png");
            Sprite = SplashKit.CreateSprite(Bitmap);

            Random random = new Random();

            location_x = random.Next(0, 700); location_y = random.Next(600, 600);


            SplashKit.SpriteSetY(Sprite, location_y);
            SplashKit.SpriteSetX(Sprite, location_x);

        }

        public override void Update(bool gameover)
        {
            if(!gameover) { 
            location_y -= speed;
            SplashKit.SpriteSetY(Sprite, location_y);
}
        }
    }
}
