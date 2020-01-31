using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Enemy : BaseClass
    {
        
        

        public Enemy(Texture2D texture1) : base(texture1)
        {
            
            position = new Vector2(150, 230);
        }

        public override void Update()
        {

        }
       

    }
}

