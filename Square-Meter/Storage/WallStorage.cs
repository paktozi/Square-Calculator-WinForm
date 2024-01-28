using Square_Meter.Models;

namespace Square_Meter.Storage
{
    public class WallStorage
    {
        List<Wall> wallList = new();

        public void AddWall(Wall wall)
        {
            wallList.Add(wall);
        }
        public double GetAllWallSum()
        {
            double sum = 0;
            foreach (var wall in wallList)
            {
                sum += wall.Width * wall.Height;
            }
            return Math.Round(sum, 2);
        }
        public void ClearStorage()
        {
            wallList.Clear();
        }

    }
}
