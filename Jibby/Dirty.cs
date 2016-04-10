using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jibby
{
    public class Dirty : IState
    {
        private Texture2D state;

        public int timer
        {
            set { timer = value; }
        }

        public Dirty(Texture2D state)
        {
            this.state = state;
        }

        public void Reaction(JibbyButton jibby, GameTime gameTime)
        {
            jibby.Texture = state;
        }
    }
}
