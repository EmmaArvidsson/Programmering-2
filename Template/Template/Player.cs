using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Template
{
    //Spelar klassen ärver från BaseClass,IUpdate och IDraw
    class Player : BaseClass,IUpdate, IDraw
        
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Vector2 velocity = Vector2.Zero;
        Vector2 gravity = new Vector2(0, 20);
        bool grounded = false;

        public Player(Texture2D texture) : base(texture)
        {
            position = new Vector2(0,230);
        }

        public void Update()
        {
            //Spelaren rör sig om man trycker på A,D eller Space
            if (Keyboard.GetState().IsKeyDown(Keys.D))
                position.X += 3;
            if (Keyboard.GetState().IsKeyDown(Keys.A))
                position.X -= 3;
            if (Keyboard.GetState().IsKeyDown(Keys.Space)  && grounded)
                
            {
                velocity.Y = -10;
                grounded = false;
            }
            if (!grounded)
            {
                position += velocity;
                velocity += gravity * 1 / 60f;
            }
            grounded = position.Y + texture.Height >= 480;
        }

        //Ritar ut spelarens textur, position och bild
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }

}
