using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Jibby
{
    public class Dead : IState
    {
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

        private Texture2D state;

        public Dead(Texture2D state)
        {
            this.state = state;
        }

        public void Reaction(JibbyButton jibby, GameTime gameTime)
        {
            jibby.Texture = state;
        }
    }
}
