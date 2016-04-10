using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jibby
{
    public class Sad : IState
    {
        private Texture2D state;

        public int timer
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Sad(Texture2D state)
        {
            this.state = state;
        }

        public void Reaction(JibbyButton jibby, GameTime gameTime)
        {
            jibby.Texture = state;
        }
    }
}
