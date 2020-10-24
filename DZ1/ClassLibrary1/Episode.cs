using System;
namespace dz1
{
    class Episode
    {
        private int ViewerCount;
        private float AverageScore;
        private float MaxScore;

        public void Episode()
        {
            this.ViewerCount = 0;
            this.AverageScore = 0.0;
            this.MaxScore = 0.0;
        }
        public void AddView(float score)
        {
            this.ViewerCount = ViewerCount + 1;
            this.AverageScore = (AverageScore + score)/ViewerCount;
            if (score > this.MaxScore)
                this.MaxScore = score;
        }

        public float GenerateRandomScore()
        {
            Random r = new Random();
            float genRand = r.Next(0, 10);
            return genRand;

        }

        public float GetMaxScore()
        {
            get {
                return MaxScore;
            }

        }
        public float GetAverageScore()
        {
            get {
                return AverageScore;
            }

        }
        public int GetViewerCount()
        {
            get {
                return ViewerCount;
            }

        }
    }
}
