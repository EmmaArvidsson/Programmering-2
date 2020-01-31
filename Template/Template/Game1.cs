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
        List<BaseClass> objectLista = new List<BaseClass>();

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D Pixel;
        Player player;
        Enemy enemy;

        

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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
          
            objectLista.Add(new Player(texture));
            Texture2D texture1 = Content.Load<Texture2D>("Enemy");
            objectLista.Add(new Enemy(texture1));
            

            
            
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
            GraphicsDevice.Clear(Color.LightPink);

            spriteBatch.Begin();
            foreach (BaseClass objekt in objectLista)
                objekt.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
