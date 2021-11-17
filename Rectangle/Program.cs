using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(0, 5, 4, 6);

            Rectangle cube = new Rectangle(5, 0, "Big");


        }
    }

    class Rectangle
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private string size;





        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public Rectangle(int x, int y, string size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

    }
}