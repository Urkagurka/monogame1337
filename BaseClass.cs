using System.Drawing;
using System.Numerics;
using Microsoft.Xna.Framework.Graphics;

namespace monogame1337
{
    public class BaseClass
    {
        protected Vector2 position;
        protected Texture2D texture;
        protected Color color;
        protected Rectangle rectangle;

        public Rectangle Rectangle{
            get{return rectangle;}
        }

        public BaseClass(Texture2D texture, Vector2 position){
            this.texture = texture;
            this.position = position;
            color = Color.White;
        }

        public virtual void Update(){
            
        }

    }
}