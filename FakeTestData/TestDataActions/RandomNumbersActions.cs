namespace FakeTestData.TestDataActions
{
    public class RandomNumbersActions
    {
        public decimal GetRandomNumber()
        {
            Random random = new Random();

            bool isInteger = random.Next(2) == 0;

            if (isInteger)
            {
                int intValue = random.Next(int.MinValue, int.MaxValue);
                return intValue;
            }

            else
            {
                float floatValue = (float)random.NextDouble() * float.MaxValue;
                return (decimal)floatValue;
            }
        }
    }
}
