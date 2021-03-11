using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Slut_Projekt.Graphics;
using Slut_Projekt.Shared;
using Slut_Projekt.Weapons;
using System;
using System.Collections.Generic;
using System.Text;
using Slut_Projekt;

namespace Slut_Projekt.Main
{
    class Player : Sprite, ILiving
    {
        #region Fields

        private Inputs _input;
        private Bullet _bullet;
        private ObjectsManager _manager;

        #endregion

        #region Properties

        public bool _isAlive { get ; private set; }

        #endregion
        public Player(Texture2D texture, Texture2D bullet, ObjectsManager manager) : base(texture)
        {
            _input = new Inputs();
            _bullet = new Bullet(bullet);
            _manager = manager;

            _origin = new Vector2(153, 255);
            Position = new Vector2(960, 1000);
        }

        #region Methods
        public override void Update(GameTime gameTime)
        {
            _input.Update();
            _rotation = (float)Math.Atan2(_input._mouseState.Y - Position.Y, _input._mouseState.X - Position.X) + (float)Math.PI/2;
            _direction = new Vector2((float)Math.Cos(_rotation + Math.PI/2), (float)Math.Sin(_rotation + Math.PI / 2));

            Inputs();
        }

        private void Inputs()
        {
            if (_input.Up)
                Position -= new Vector2(0, 1) * MovementSpeed;

            if (_input.Down)
                Position += new Vector2(0, 1) * MovementSpeed;

            if (_input.Right)
                Position += new Vector2(1, 0) * MovementSpeed;

            if (_input.Left)
                Position -= new Vector2(1, 0) * MovementSpeed;

            if (_input.Shoot)
                Shoot();
        }
        private void Shoot()
        {
            Bullet Bullet = _bullet.Clone() as Bullet;
            Bullet._direction = this._direction;
            Bullet.Position = this.Position;

            _manager.AddObject(Bullet);

        }

        #endregion
    }
}
