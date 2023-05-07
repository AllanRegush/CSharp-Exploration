namespace BlazorServerMessageWall.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private int otherCount = 0;
        private void IncrementCount()
        {
            currentCount += 10;
            otherCount += 1;
        }
    }
}