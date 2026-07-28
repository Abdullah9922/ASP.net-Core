
    public class Rectangle
    {
        private double _lenght;
        private double _width;

        public double Length
        {
            get { return _lenght; }
            set { if (value > 0) _lenght = value; }
        }

        public double Width
        {
            get { return _width; }
            set { if (value > 0) _width = value; }
        }

        public double Area
        {
            get { return Length * Width; }
        }

        public double Perimeter
        {
            get { return 2*(Length + Width); }
        }

        public Rectangle() : this(0)
        {

        }

        public Rectangle(double length) : this(length, 0)
        {

        }

        public Rectangle(double length, double width)
        {
            _lenght = length;
            _width = width;
        }

        public void Display()
        {
            Console.WriteLine("Length : " + Length);
            Console.WriteLine("Width  : " + Width);
            Console.WriteLine("Area   : " + Area);
            Console.WriteLine("Perimeter: " + Perimeter);
        }

    }

