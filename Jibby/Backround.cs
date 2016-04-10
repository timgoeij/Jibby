using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jibby
{
    public class Backround : GameObject
    {
        public Backround(Vector2 position)
            : base(position)
        {

        }

        public override void loadContent(Texture2D texture)
        {
            base.loadContent(texture);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            base.Draw(spritebatch);
        }
    }
}
