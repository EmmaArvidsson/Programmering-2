using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {

        private static List<IUpdate> update = new List<IUpdate>();
        private static List<IDraw> draw = new List<IDraw>();
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        


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
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D texture = Content.Load<Texture2D>("Player");
            Texture2D texture1 = Content.Load<Texture2D>("Enemy");

            Player p = new Player(texture);
            AddIDraw(p as IDraw);
            Enemy e = new Enemy(texture);
            AddIDraw(e as IDraw);
           
        }

     
        protected override void UnloadContent()
        {
            
        }

      
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        
        /// <param name="gameTime"
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();

            foreach (IDraw id in draw)
                id.Draw(spriteBatch);
            
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
