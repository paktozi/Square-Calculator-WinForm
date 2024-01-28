using Square_Meter.Models;

namespace Square_Meter.Storage
{
    public class RevealStorage
    {

        List<Reveal> revealList = new();

        public void AddReveal(Reveal reveal)
        {
            revealList.Add(reveal);
        }
        public double GetAllRevealSum()
        {
            double sum = 0;
            foreach (var reveal in revealList)
            {
                sum += reveal.SquareM;

            }
            return Math.Round(sum, 2);
        }
        public void ClearStorage()
        {
            revealList.Clear();
        }
    }
}
