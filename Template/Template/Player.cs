using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Template
{
    class Player
    {
        private Texture2D texture;
        private Vector2 position;

        public Player(Texture2D texture)
        {
            this.texture = texture;
            position = new Vector2(0,230);
        }

        public void Update()
        {

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, Color.White);
            spriteBatch.End();

        }

    }
}
