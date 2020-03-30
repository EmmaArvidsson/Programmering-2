using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Template
{

    //Enum kanske ska vara en klass?
    private enum Paus

        if(meny == Meny.PausMenu)
            {
            //Antar att om meny är pausmeny så ska spelet pausa. 
            //Om det inte är det så ska spelet köra

            }
    


    
    public class Game1 : Game
    {

        private static List<IUpdate> update = new List<IUpdate>();
        private static List<IDraw> draw = new List<IDraw>();
        
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        SoundEffect soundEffect;

        float time;

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

            //laddar in bilder till fiende och spelare och laddar in ljud
            Texture2D texture = Content.Load<Texture2D>("Player");
            Texture2D texture1 = Content.Load<Texture2D>("Enemy");
            soundEffect = Content.Load<SoundEffect>("supermario");

            Player p = new Player(texture);
            AddIDraw(p as IDraw);
            Enemy e = new Enemy(texture1, new Vector2(50,200));
            AddIDraw(e as IDraw);
            AddIUpdate(e as IUpdate);
            AddIUpdate(p as IUpdate);
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

            time += (float)gameTime.ElapsedGameTime.TotalSeconds;

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
