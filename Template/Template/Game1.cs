using Microsoft.Xna.Framework;
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
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteBatch Font;

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

        
        protected override void LoadContent()
        {
           
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //laddar in bilder till fiende och spelare
            Texture2D texture = Content.Load<Texture2D>("Player");
            Texture2D texture1 = Content.Load<Texture2D>("Enemy");

            Font = Content.Load<SpriteFont>("Tidtagare");

            Player p = new Player(texture);
            AddIDraw(p as IDraw);
            Enemy e = new Enemy(texture1, new Vector2(50,200));
            AddIDraw(e as IDraw);
            AddIUpdate(e as IUpdate);
            AddIUpdate(p as IUpdate);

            //ascii för space, D och A
            Keys forward = (Keys)87;
           
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
            timecounter += (int)timer;
            if (timer >= 1.0f) timer = 0f;


            base.Update(gameTime);
        }

        
        /// <param name="gameTime"
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            //Ritar ut det som står mellan citattecknen             
            string output = "tiden";                          
            //Ritar ut string             
            SpriteBatch.DrawString(Font, ouput, Color.Red, 0, FontOrigin, 1.0f, SpriteEffects.None, 0, 5f);

            foreach (IDraw id in draw)
                id.Draw(spriteBatch);
            
            
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
