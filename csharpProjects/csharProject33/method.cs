namespace myApp
{
    public class methods
    {
        void DisplayAdjustedTimes (int[] times ,int currentGMT, int newGMT)
        {
            int diff = 0;
            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLinte("Invalid GMT");
            }
        }
    }
    
}