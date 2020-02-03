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
    class Player : BaseClass
    {
        Vector2 velocity = Vector2.Zero;
        Vector2 gravity = new Vector2(0, 20);
        bool grounded = false;

        public Player(Texture2D texture) : base(texture)
        {
            
            position = new Vector2(0,230);
        }

        public override void Update()
        {
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


    }
}
