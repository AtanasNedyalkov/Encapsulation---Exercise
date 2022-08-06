using System;
using System.Text;

namespace ClassBoxData
{
   public class Box
    {
        private const double IsZeroOrNegative = 0;
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght 
        {
            get 
            {
                return this.lenght;
            }
            private set
            {
                if (value<=IsZeroOrNegative)
                {
                    throw new ArgumentException($"{nameof(this.Lenght)} cannot be zero or negative.");
                }

                this.lenght = value;
            }
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value<=IsZeroOrNegative)
                {
                    throw new ArgumentException($"{nameof(this.Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }

        public double Height 
        {
            get 
            {
                return this.height;
            }
            private set 
            {
                if (value<=IsZeroOrNegative)
                {
                    throw new ArgumentException($"{nameof(this.Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
        }

//Volume = lwh
//Lateral Surface Area = 2lh + 2wh
//Surface Area = 2lw + 2lh + 2wh
        public double SurfaceArea()
        {
            return (2 * this.Lenght * this.Width) +
                   (2 * this.Lenght * this.Height) +
                    (2 * this.Width * this.Height);
        }
        public double LeretalSurface()
            => 2 * this.Lenght * this.height + 2 * this.Width * this.Height;
        public double Volume()
            => this.Height * this.Width * this.Lenght;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LeretalSurface():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
