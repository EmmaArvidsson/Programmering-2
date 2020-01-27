using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Enemy
    {
        private Texture2D texture1;
        private Vector2 position;

        public Enemy(Texture2D texture1)
        {
            this.texture1 = texture1;
            position = new Vector2(150, 230);
        }

        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture1, position, Color.White);
            spriteBatch.End();

        }

    }
}

