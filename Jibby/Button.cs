using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Jibby
{
    public class Button : GameObject
    {
        protected JibbyButton jibby;
        protected Texture2D onState;
        protected Texture2D offState;
        private MouseState mouse;
        private MouseState oldMouse;

        public Button(Vector2 position)
            :base(position)
        {
            
        }

        public virtual void Click()
        {

        }

        public override void Update(GameTime gameTime)
        {
            mouse = Mouse.GetState();

            bool clicked = (mouse.LeftButton != oldMouse.LeftButton && mouse.LeftButton == ButtonState.Pressed);

            if (rectangle.Contains(mouse.Position) && clicked)
                Click();

            oldMouse = mouse;

            base.Update(gameTime);
        }

        public virtual void SetJibby(JibbyButton jibby)
        {
            this.jibby = jibby;
        }

        public virtual void LoadButtonStates(Texture2D on, Texture2D off)
        {
            onState = on;
            offState = off;
        }
    }
}
