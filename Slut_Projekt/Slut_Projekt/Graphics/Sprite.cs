using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Slut_Projekt.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slut_Projekt.Graphics
{
    class Sprite : BaseObject, ICloneable
    {
        private const Double SPRITE_DIRTECTION_CORRECTION = Math.PI/2;


        private Texture2D _texture;
        // Origin point to rotate around.
        protected Vector2 _origin;


        public float _rotation;
        public Vector2 _direction;
        public Vector2 Position;


        public bool ShouldRemove { get; set; } = false;
        protected float RotationVelocity { get; set; } = 3f;
        protected float MovementSpeed { get; set; } = 5f;
        


        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }



        public override void Update(GameTime gameTime)
        {

        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            spriteBatch.Draw(_texture, Position, null, Color.White, _rotation, _origin, 1, SpriteEffects.None, 0);
        }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
