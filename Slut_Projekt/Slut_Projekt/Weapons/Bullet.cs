using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Slut_Projekt.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slut_Projekt.Weapons
{
    class Bullet : Sprite
    {
        public float LifeSpan { get; set; } = 3f;
        public float Timer { get; set; }

        public Bullet(Texture2D texture) : base(texture)
        {
            MovementSpeed = 20;
        }

        public override void Update(GameTime gameTime)
        {

            Timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            Position -= _direction * MovementSpeed;

            if (Timer > LifeSpan)
                ShouldRemove = true;
        }

    }
}
