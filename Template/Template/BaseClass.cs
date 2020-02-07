using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
