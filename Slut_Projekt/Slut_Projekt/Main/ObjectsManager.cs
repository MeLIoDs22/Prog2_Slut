using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Slut_Projekt.Graphics;
using Slut_Projekt.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Slut_Projekt.Shared;

namespace Slut_Projekt.Main
{
    class ObjectsManager : BaseObject
    {
        #region Fields
        private List<Sprite> _objects;
        private Dictionary<string, Texture2D> _textures;
        private Dictionary<string, SoundEffect> _sounds;

        #endregion

        #region Properties
        public IReadOnlyCollection<Sprite> Objects
        {
            get
            {
                return _objects.AsReadOnly();
            }
        }

        #endregion

        #region Methods
        public ObjectsManager()
        {
            _objects = new List<Sprite>();
            _textures = new Dictionary<string, Texture2D>();
            _sounds = new Dictionary<string, SoundEffect>();
        }

        #region IBasicObject
        public override void Update(GameTime gameTime)
        {
            if (_objects.Any())
            {
                foreach (var i in _objects.ToArray())
                {
                    if (i.ShouldRemove)
                        _objects.Remove(i);
                    i.Update(gameTime);
                }
                    
            }
        }
        public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            if (_objects.Any())
            {
                foreach (var i in _objects)
                    i.Draw(spriteBatch, gameTime);
            }
        }

        #endregion

        #region Add_Remove_Objects
        public void AddObject(Sprite sprite)
        {
            if (sprite != null)
                _objects.Add(sprite);
        }
        public void RemoveObject(Sprite sprite)
        {
            if (sprite != null)
                if (_objects.Contains(sprite))
                    _objects.Remove(sprite);
        }

        #endregion

        #region Add_Content

        public void AddTexture(string textureName, Texture2D texture)
        {
            if(texture != null)
            {
                if (_textures.ContainsKey(textureName))
                    throw new Exception("Texture already exists.");
                else
                    _textures.Add(textureName, texture);
            }
        }

        public void AddSound(string soundName, SoundEffect sound)
        {
            if(sound != null)
            {
                if (_sounds.ContainsKey(soundName))
                    throw new Exception("SoundEffect already exists.");
                else
                    _sounds.Add(soundName, sound);
            }
        }
        #endregion
        public void Start()
        {
            var Player = new Player(_textures["Player"], _textures["Bullet"], this);
            AddObject(Player);
        }
        #endregion
    }
}
