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

        public void Update()
        {

            if (Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.W))
                Up = true;
            else { Up = false; }


            if(Keyboard.GetState().IsKeyDown(Keys.Down) || Keyboard.GetState().IsKeyDown(Keys.S))
                Down = true;
            else { Down = false; }

            
            if(Keyboard.GetState().IsKeyDown(Keys.Left) || Keyboard.GetState().IsKeyDown(Keys.A))
                Left = true;
            else { Left = false; }

            
            if(Keyboard.GetState().IsKeyDown(Keys.Right) || Keyboard.GetState().IsKeyDown(Keys.D))
                Right = true;
            else { Right = false; }

        }
    }
}
