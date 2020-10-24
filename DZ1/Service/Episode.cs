namespace Service
{
    public class Episode
    {
        private int ViewerCount;
        private double TotalSum;
        private double MaxScore;
        
        public Episode() { }

        public Episode(int viewerCount, double totalScore, double maxScore)
        {
            ViewerCount = viewerCount;
            TotalSum = totalScore;
            MaxScore = maxScore;
        }

        public void AddView(double score)
        {
            ViewerCount = ViewerCount + 1;
            this.TotalSum = TotalSum + score;
            if (score > this.MaxScore)
                MaxScore = score;
        }

        public double GetMaxScore()
        {
            return MaxScore;
        }

        public double GetAverageScore()
        {
            return TotalSum/ViewerCount;
        }

        public int GetViewerCount()
        {
            return ViewerCount;
        }
    }
}
