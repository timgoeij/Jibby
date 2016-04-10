using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Jibby
{
    public class Wash : Button
    {
        public Wash(Vector2 position)
            : base(position)
        {

        }

        public override void Click()
        {
            jibby.IsWashing = true;
            jibby.behaviour = new Showering(jibby.shower);
        }

        public override void LoadButtonStates(Texture2D on, Texture2D off)
        {
            base.LoadButtonStates(on, off);
        }

        public override void Update(GameTime gameTime)
        {
            if (jibby.IsWashing)
                texture = onState;
            else
                texture = offState;

            base.Update(gameTime);
        }

        public override void SetJibby(JibbyButton jibby)
        {
            base.SetJibby(jibby);
        }
    }
}
