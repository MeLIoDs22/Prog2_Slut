using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slut_Projekt.Shared
{
    class Input
    {
        public bool Up;
        public bool Down;
        public bool Left;
        public bool Right;

        public bool Shoot;

        private KeyboardState _keyState;
        private KeyboardState _oldKeyState;

        public MouseState _mouseState;
        public MouseState _oldMouseState;
        public void Update()
        {
            _oldKeyState = _keyState;
            _keyState = Keyboard.GetState();

            _oldMouseState = _mouseState;
            _mouseState = Mouse.GetState();

            if (_keyState.IsKeyDown(Keys.Up) || _keyState.IsKeyDown(Keys.W))
                Up = true;
            else { Up = false; }


            if(_keyState.IsKeyDown(Keys.Down) || _keyState.IsKeyDown(Keys.S))
                Down = true;
            else { Down = false; }

            
            if(_keyState.IsKeyDown(Keys.Left) || _keyState.IsKeyDown(Keys.A))
                Left = true;
            else { Left = false; }

            
            if(_keyState.IsKeyDown(Keys.Right) || _keyState.IsKeyDown(Keys.D))
                Right = true;
            else { Right = false; }


            if (_mouseState.LeftButton == ButtonState.Pressed && _oldMouseState.LeftButton != ButtonState.Pressed || _keyState.IsKeyDown(Keys.Space) && !_oldKeyState.IsKeyDown(Keys.Space))
                Shoot = true;
            else { Shoot = false; }
        }
    }
}
