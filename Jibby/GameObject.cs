using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jibby
{
    public abstract class GameObject
    {
        protected Texture2D texture;

        protected Vector2 position;

        protected Rectangle rectangle;

        public Rectangle Rectangle
        {
            get { return rectangle; }
        }


        public GameObject(Vector2 position)
        {
            this.position = position;

            rectangle.X = (int)position.X;
            rectangle.Y = (int)position.Y;
        }


        public virtual void loadContent(Texture2D texture)
        {
            this.texture = texture;
            rectangle.Width = texture.Width;
            rectangle.Height = texture.Height;
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, rectangle, Color.White);
        }
    }
}
