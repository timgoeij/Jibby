using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jibby
{
    public class Showering : IState
    {
        private Texture2D state;

        public int timer
        {
            get;
            set;
        }

        private float count = 0;

        public Showering(Texture2D state)
        {
            this.state = state;
            timer = 4;
        }

        public void Reaction(JibbyButton jibby, GameTime gameTime)
        {
            count += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (count < timer)
            {
                jibby.Texture = state;
            }
            else
                jibby.IsWashing = false;
        }
    }
}
