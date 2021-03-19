using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SpaceShooter3
{
    abstract class Enemy : PhysicalObject //Klass som ger de skapade fiende-entiteterna ett utseende, en position och en hastighet. 
    {
        public Enemy(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y, speedX, speedY)
        {

        }

        public abstract void Update(GameWindow window);
    }
}
