using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Slut_Projekt.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slut_Projekt.Graphics
{
    class Sprite
    {
        private const Double SPRITE_DIRTECTION_CORRECTION = Math.PI/2;


        private Texture2D _texture;
        // Origin point to rotate around.
        protected Vector2 _origin;


        protected float _rotation;
        protected Vector2 _direction;


        protected Vector2 Position { get; set; }
        protected float RotationVelocity { get; set; } = 3f;
        protected float MovementSpeed { get; set; } = 5f;




        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }



        public virtual void Update(GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, Position, null, Color.White, _rotation, _origin, 1, SpriteEffects.None, 0);
        }


    }
}
