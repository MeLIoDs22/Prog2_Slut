using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Slut_Projekt.Shared
{
    class Input
    {
        public bool up;
        public bool down;
        public bool left;
        public bool right;

        public void Update()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.W))
            {
                up = true;
            }
            else { up = false; }
            
            if(Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S))
            {
                down = true;
            }
            else { down = false; }
            
            if(Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.A))
            {
                left = true;
            }
            else { left = false; }
            
            if(Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.D))
            {
                right = true;
            }
            else { right = false; }
        }
    }
}
