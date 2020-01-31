using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Template
{
    class Player : BaseClass
    {
        

        public Player(Texture2D texture) : base(texture)
        {
            
            position = new Vector2(0,230);
        }

        public override void Update()
        {

        }


    }
}
