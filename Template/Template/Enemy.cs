using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Template
{
    //Fienden ärver från BaseClass, IUpdate och IDraw
    class Enemy : BaseClass,IUpdate, IDraw
        
    {
        Vector2 velocity = Vector2.Zero;
        //Vet heller inte var den ska vara i Enemy
        //Kommer hitboxen att följa med fienden när den trillar ner?
        Rectangle rec2 = new Rectangle(0, 10, 20, 20);

 
        public Enemy(Texture2D texture1, Vector2 position) : base(texture1)
        {
            position = new Vector2(0, 10);
        }

        public void Update()
        {
            //Fienden trillar ner med 5 pixlar i sekunden. Om positionen är större än 400 så stannar fienden
            velocity.Y += 5 * (1f/60);
            position += velocity;
            if(position.Y > 400)
            {
                position.Y = 400;
                velocity.Y = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}

