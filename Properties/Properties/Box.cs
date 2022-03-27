using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        // no class can access them directly only by properties ..
        private int length;
        private int height;
        //public int width;
        public int volume;
        private int frontSurface;
        public int Width { get; set; }

        public int FrontSurface
        {
            get
            {
                return height * length;
            }
        }
        public int Height
        {
            get
            {
                return height; 
            }
            set
            {
                if (value < 0) { 
                    height = -value; }
                else
                {
                    height = value; 
                }
                
            }
        }
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.Width = width;
        }
        // create a setter 
        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be positive");
            }
            this.length = length;
        }
        // create a getter 
        public int GetLength()
        {
            return this.length;
        }
        public int GetVolume()
        {

            return this.length * this.Width * this.height;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Lenth is {0} and height is {1} and width is {2} so volume is {3}", length, height, Width, volume = GetVolume());
        }
    }
}
