using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Jibby
{
    public class World
    {
        Backround background;
        JibbyButton jibby;
        Wash wash;
        Food food;
        MousePointer pointer;

        public World()
        {
            background = new Backround(new Vector2(0, 0));

            jibby = new JibbyButton(new Vector2((Game1.game.GraphicsDevice.Viewport.Width / 2) -175, 0));

            wash = new Wash(new Vector2((Game1.game.GraphicsDevice.Viewport.Width / 2) - 250, 
                Game1.game.GraphicsDevice.Viewport.Height - 110));
            wash.SetJibby(jibby);

            food = new Food(new Vector2((Game1.game.GraphicsDevice.Viewport.Width / 2), 
                Game1.game.GraphicsDevice.Viewport.Height - 110));
            food.SetJibby(jibby);

            pointer = new MousePointer();
        }

        public void LoadContent()
        {
            Texture2D backgroundTex = Game1.game.Content.Load<Texture2D>("jibby_bg");
            background.loadContent(backgroundTex);

            Texture2D jibbyTex = Game1.game.Content.Load<Texture2D>("jibbyHappy");
            Texture2D jibbyHungry = Game1.game.Content.Load<Texture2D>("jibbyHungry");
            Texture2D jibbySad = Game1.game.Content.Load<Texture2D>("jibbySad");
            Texture2D jibbyDirty = Game1.game.Content.Load<Texture2D>("jibbyDirty");
            Texture2D jibbyDead = Game1.game.Content.Load<Texture2D>("jibbyDead");

            SpriteFont font = Game1.game.Content.Load<SpriteFont>("Verdana");
            jibby.loadContent(jibbyTex);
            jibby.SetStateTex(jibbySad, jibbyDead, jibbyHungry, jibbyDirty, jibbyTex, font);

            jibby.Eat = Game1.game.Content.Load<Texture2D>("JibbyEating");
            jibby.shower = Game1.game.Content.Load<Texture2D>("JibbyWashing");

            Texture2D washTex = Game1.game.Content.Load<Texture2D>("btn_wash_off");
            Texture2D washTexOn = Game1.game.Content.Load<Texture2D>("btn_wash_on");
            wash.loadContent(washTex);
            wash.LoadButtonStates(washTexOn, washTex);

            Texture2D foodTex = Game1.game.Content.Load<Texture2D>("btn_eat_off");
            Texture2D foodTexOn = Game1.game.Content.Load<Texture2D>("btn_eat_on");
            food.loadContent(foodTex);
            food.LoadButtonStates(foodTexOn, foodTex);

            Texture2D pointerTex = Game1.game.Content.Load<Texture2D>("bluecursor");
            Texture2D handClosed = Game1.game.Content.Load<Texture2D>("hand_closed");
            Texture2D handOpen = Game1.game.Content.Load<Texture2D>("hand_open");
            pointer.LoadContent(pointerTex, handOpen, handClosed);
        }

        public void Update(GameTime gameTime)
        {
            jibby.Update(gameTime);
            pointer.Update(jibby);
            wash.Update(gameTime);
            food.Update(gameTime);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Begin();

            background.Draw(spritebatch);
            jibby.Draw(spritebatch);
            wash.Draw(spritebatch);
            food.Draw(spritebatch);


            pointer.Draw(spritebatch);

            spritebatch.End();
        }
    }
}
