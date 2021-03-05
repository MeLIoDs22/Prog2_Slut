using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Slut_Projekt.Graphics;
using Slut_Projekt.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slut_Projekt.Main
{
    class Player : Sprite
    {
        private Input _input;


        public Player(Texture2D texture) : base(texture)
        {
            _input = new Input();

            _origin = new Vector2(153, 255);
            Position = new Vector2(960, 1000);
        }

        public override void Update(GameTime gameTime)
        {
            _input.Update();

            Movement();
        }

        private void Movement()
        {
            if (_input.Up)
                Position += _direction * MovementSpeed;

            if (_input.Down)
                Position -= _direction * MovementSpeed;

            if (_input.Right)
                Position += new Vector2(1, 0) * MovementSpeed;

            if (_input.Left)
                Position -= new Vector2(1, 0) * MovementSpeed;
        }
    }
}
