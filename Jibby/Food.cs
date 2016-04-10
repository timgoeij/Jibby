using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Jibby
{
    public class Food : Button
    {
        public Food(Vector2 position)
            :base(position)
        {

        }

        public override void Click()
        {
            jibby.IsEating = true;
            jibby.behaviour = new Eating(jibby.Eat);
        }

        public override void LoadButtonStates(Texture2D on, Texture2D off)
        {
            base.LoadButtonStates(on, off);
        }

        public override void Update(GameTime gameTime)
        {
            if (jibby.IsEating)
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
