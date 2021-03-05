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

namespace Slut_Projekt.Main
{
    class ObjectsManager
    {
        
        private List<Sprite> _objects;
        private List<Texture2D> _textures;
        private List<SoundEffect> _sounds;

        public IReadOnlyCollection<Sprite> Objects
        {
            get
            {
                return _objects.AsReadOnly();
            }
        }
        public IReadOnlyCollection<Texture2D> Textures
        {
            get
            {
                return _textures.AsReadOnly();
            }
        }
        public IReadOnlyCollection<SoundEffect> Sounds
        {
            get
            {
                return _sounds.AsReadOnly();
            }
        }

        public ObjectsManager()
        {
            _objects = new List<Sprite>();
            _textures = new List<Texture2D>();
            _sounds = new List<SoundEffect>();
        }

        public void Update(GameTime gameTime)
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
        public void Draw(SpriteBatch spriteBatch)
        {
            if (_objects.Any())
            {
                foreach (var i in _objects)
                    i.Draw(spriteBatch);
            }
        }



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



        public void Load(ContentManager content, List<string> textures = null, List<string> sounds = null)
        {
            if (textures != null)
            {
                foreach (var i in textures)
                    _textures.Add(content.Load<Texture2D>(i));
            }

            if (sounds != null)
            {
                foreach (var i in sounds)
                    _sounds.Add(content.Load<SoundEffect>(i));
            }
        }

        public void Start()
        {
            var Player = new Player(_textures[0], _textures[1], this);
            AddObject(Player);
        }

    }
}
