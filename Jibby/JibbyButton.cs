using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Jibby
{
    public class JibbyButton :Button
    {
        private Texture2D sadTex;
        private Texture2D deadTex;
        private Texture2D hungryTex;
        private Texture2D dirtyTex;
        private Texture2D happyTex;
        private SpriteFont text;

        public Texture2D Eat
        {
            get;
            set;
        }

        public Texture2D shower
        {
            get;
            set;
        }

        private IState stateBehaviour;

        public int hungryMeter = 25;
        public int dirtyMeter = 25;
        public int happyMeter = 10;

        private float timer = 0;

        private bool isHungry;
        private bool isDirty;
        private bool isSad;
        private bool isEating;
        private bool isWashing;

        public bool IsWashing
        {
            get { return isWashing; }
            set { isWashing = value; }
        }

        public bool IsEating
        {
            get { return isEating; }
            set { isEating = value; }
        }

        public Texture2D Texture
        {
            set { texture = value; }
        }

        public IState behaviour
        {
            set { stateBehaviour = value; }
        }

        public JibbyButton(Vector2 position)
            : base(position)
        {
          
        }

        public void SetStateTex(Texture2D sad, Texture2D dead, Texture2D hungry, Texture2D dirty, Texture2D happy, SpriteFont text)
        {
            this.sadTex = sad;
            this.deadTex = dead;
            this.hungryTex = hungry;
            this.dirtyTex = dirty;
            this.happyTex = happy;
            this.text = text;
        }

        public override void Click()
        {
            happyMeter += 5;
        }

        public override void Update(GameTime gameTime)
        {
            timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            checkState();

            if (timer > 1)
            {

                if(hungryMeter != 0 && !isEating)
                    hungryMeter -= 1;

                if(dirtyMeter != 0 && !isWashing)
                    dirtyMeter -= 1;


                if (hungryMeter < 10 && dirtyMeter < 10)
                {
                    if(happyMeter != 0)
                        happyMeter -= 1;
                }
                    
                timer = 0;
            }

            stateBehaviour.Reaction(this, gameTime);

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            spritebatch.DrawString(text, happyMeter.ToString(), new Vector2(445, 65), Color.Black);
            spritebatch.DrawString(text, hungryMeter.ToString(), new Vector2(325, 65), Color.Black);
            spritebatch.DrawString(text, dirtyMeter.ToString(), new Vector2(200, 65), Color.Black);

            base.Draw(spritebatch);
        }

        private void checkState()
        {
            isDirty = dirtyMeter < 10;
            isHungry = hungryMeter < 10;
            isSad = happyMeter < 8;

            if(!isEating && !isWashing)
            {
                if (hungryMeter == 0 || dirtyMeter == 0 || happyMeter == 0)
                    stateBehaviour = new Dead(deadTex);
                else if (isSad)
                    stateBehaviour = new Sad(sadTex);
                else if (isHungry)
                    stateBehaviour = new Hungry(hungryTex);
                else if (isDirty)
                    stateBehaviour = new Dirty(dirtyTex);
                else
                    stateBehaviour = new Happy(happyTex);
            }
        }
    }
}
