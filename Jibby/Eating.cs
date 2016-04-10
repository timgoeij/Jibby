using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jibby
{
    public class Eating : IState
    {
        private Texture2D state;
        private float count = 0;

        public int timer
        {
            get;
            set;
        }

        public Eating(Texture2D state)
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
                jibby.IsEating = false;
        }
    }
}
