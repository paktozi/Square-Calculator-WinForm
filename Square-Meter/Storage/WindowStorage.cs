using Square_Meter.Models;

namespace Square_Meter.Storage
{
    public class WindowStorage
    {

        List<Window> windowlist = new();

        public void AddWindow(Window window)
        {
            windowlist.Add(window);
        }
        public double GetAllWindowsSum()
        {
            double sum = 0;
            foreach (var window in windowlist)
            {
                sum += window.Width * window.Height;
            }
            return Math.Round(sum, 2);
        }
        public void ClearStorage()
        {
            windowlist.Clear();
        }


    }
}
