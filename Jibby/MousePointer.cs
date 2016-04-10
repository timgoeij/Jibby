using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Jibby
{
    public class MousePointer
    {
        private Texture2D pointer;
        private Texture2D handOpen;
        private Texture2D handClosed;

        private Texture2D texture;
        private Vector2 position;

        private MouseState state;

        public MousePointer()
        {

        }

        public void LoadContent(Texture2D pointer, Texture2D handOpen, Texture2D handClosed)
        {
            this.pointer = pointer;
            this.handClosed = handClosed;
            this.handOpen = handOpen;
        }

        public void Update(JibbyButton jibby)
        {
            state = Mouse.GetState();

            position = new Vector2(state.X, state.Y);

            if (jibby.Rectangle.Contains(position))
            {
                if (state.LeftButton == ButtonState.Pressed)
                    texture = handClosed;
                else
                    texture = handOpen;
            }
            else
                texture = pointer;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
