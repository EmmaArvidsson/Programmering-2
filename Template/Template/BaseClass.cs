using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Template
{
    class BaseClass
    {
        protected Texture2D texture;
        protected Vector2 position;

        public BaseClass(Texture2D texture)
        {
            this.texture = texture;
        }


        public virtual void  Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
