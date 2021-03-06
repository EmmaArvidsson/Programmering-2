﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Threading;

namespace Template
{
    
    public class Game1 : Game
    {
        //Tre stycken olika "states" som spelet kan vara i
         enum GameState
        {
            GamePlaying,
            Pause,
            GameOver
        }

        GameState gameState = new GameState();

        private static List<IUpdate> update = new List<IUpdate>();
        private static List<IDraw> draw = new List<IDraw>();


        //Spelarens hitbox
        Rectangle rec1 = new Rectangle(0, 230, 20, 20);

        //Fiendens hitbox
        Rectangle rec2 = new Rectangle(0, 10, 20, 20);


        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont Font;

        float timer;
        int timecounter;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        public static void AddIUpdate(IUpdate iu)
        {
            update.Add(iu);
        }

        public static void AddIDraw(IDraw id)
        {
            draw.Add(id);
        }

       
        protected override void Initialize()
        {
            base.Initialize();
        }

        //Metod som säger vad som händer om fiende kolliderar med spelaren
        private void Colission()
        {
            if (rec2.Intersects(Player.rec1))
            {
                Collide();

            }

        }


        protected override void LoadContent()
        {
           
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //laddar in bilder till fiende och spelare
            Texture2D texture = Content.Load<Texture2D>("Player");
            Texture2D texture1 = Content.Load<Texture2D>("Enemy");

            Font = Content.Load<SpriteFont>("Tidtagare");

            //Ger spelaren sin textur och lägger till spelare i IDraw och IUpdate
            Player p = new Player(texture);
            AddIDraw(p as IDraw);
            AddIUpdate(p as IUpdate);

            //Ger fienden sin textur och lägger till fiende i IDraw och IUpdate
            Enemy e = new Enemy(texture1, new Vector2(50,200));
            AddIDraw(e as IDraw);
            AddIUpdate(e as IUpdate);
           
        }

     
        protected override void UnloadContent()
        {
            
        }

        
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            foreach (IUpdate iu in update)
                iu.Update();

            //Tiden
            timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

            base.Update(gameTime);
        }

        
        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            //Ritar ut det som står mellan citattecknen             
            string output = "tiden";                          
            //Ritar ut string             
            spriteBatch.DrawString(Font, output + (int)timer, new Vector2(10,10) , Color.Red);
            
            foreach (IDraw id in draw)
                id.Draw(spriteBatch);
            
            
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
