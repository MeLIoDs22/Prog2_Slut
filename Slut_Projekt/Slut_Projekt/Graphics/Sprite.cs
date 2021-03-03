using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Slut_Projekt.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slut_Projekt.Graphics
{
    /// <summary>
    /// 
    /// </summary>
    class Sprite
    {
        // Monogame assumes that the sprite is pointed to the right by default. Mine are pointed forward.
        private const Double SPRITE_DIRTECTION_CORRECTION = Math.PI/2;


        private Texture2D _texture;
        private Vector2 _direction;
        private Vector2 _origin;
        private float _rotation;

        public Input _input;
        public Vector2 position;

        public float rotationVelocity { get; set; } = 3f;
        public float movmentSpeed { get; set; } = 5f;

        public Sprite(Texture2D texture, Vector2 origin)
        {
            _texture = texture;
            _origin = origin;
        }

        public void Update(GameTime gameTime)
        {
            if (_input == null)
                return;

            _input.Update();


            if (_input.right)
                _rotation += MathHelper.ToRadians(rotationVelocity);
            
            if (_input.left)
                _rotation -= MathHelper.ToRadians(rotationVelocity);

            _direction = new Vector2((float)Math.Cos(SPRITE_DIRTECTION_CORRECTION + _rotation) , (float)Math.Sin(SPRITE_DIRTECTION_CORRECTION + _rotation) );

            if (_input.up)
                position -= _direction * movmentSpeed;
            
            if (_input.down)
                position += _direction * movmentSpeed;
        }
        
        public void Draw(SpriteBatch spriteBatch, Rectangle size)
        {
            size = new Rectangle((int)position.X, (int)position.Y, 200, 200);
            spriteBatch.Draw(_texture, size, null, Color.White, _rotation, _origin, SpriteEffects.None, 0);
        }
    }
}
