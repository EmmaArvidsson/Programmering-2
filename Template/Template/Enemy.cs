using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Template
{
    class Enemy : BaseClass,IUpdate, IDraw
    {
        int radie = 100;
        float vinkel = 0;
        Vector2 mittenposition;
        static Random r = new Random();
        float rotation = 0.01f;

        public Enemy(Texture2D texture1, Vector2 position) : base(texture1)
        {

            mittenposition = position;
            vinkel = (float)r.NextDouble();
            if (r.Next(0, 2) == 0)
                rotation *= -1;
        }

        public void Update()
        {
            Vector2 dir = new Vector2();
            dir.X = (float)Math.Sin(vinkel);
            dir.Y = (float)Math.Cos(vinkel);
            position = mittenposition + dir * radie;
            vinkel+= rotation;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}

