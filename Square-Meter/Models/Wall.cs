namespace Square_Meter.Models
{
    public class Wall
    {

        public Wall(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }

        public double Width { get; set; }

        public string GetSquareMeters() => Math.Round(Height * Width, 2).ToString() + "m²";

    }
}
