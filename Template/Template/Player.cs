using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework;

namespace Template
{
    //Spelar klassen ärver från BaseClass,IUpdate och IDraw
    class Player : BaseClass,IUpdate, IDraw
        
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        List<SoundEffect> soundEffects;

        //vet inte var hitboxen ska vara i player klassen
        //Vet heller inte hur stor hitboxen ska vara på spelaren
        Rectangle rec1 = new Rectangle(0, 230, 20, 20);

        if (rec1.Intersects(rec2))
            Collide();


        Vector2 velocity = Vector2.Zero;
        Vector2 gravity = new Vector2(0, 20);
        bool grounded = false;

        public Player(Texture2D texture) : base(texture)
        {
            position = new Vector2(0,230);
            ;

            soundEffects[0].Play();

            var instance = soundEffects[0].CreateInstance();
            instance.IsLooped = true;
            instance.Play();
        }

        public void Update()
        {
            //Spelaren rör sig om man trycker på A,D eller Space, när man trycker på Space så kommer det ljud
            if (Keyboard.GetState().IsKeyDown(Keys.D))
                position.X += 3;
            if (Keyboard.GetState().IsKeyDown(Keys.A))
                position.X -= 3;
            if (Keyboard.GetState().IsKeyDown(Keys.Space)  && grounded)
                
            {
                soundEffects[0].CreateInstance().Play();

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
