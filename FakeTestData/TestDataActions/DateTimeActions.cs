namespace FakeTestData.TestDataActions
{
    public class DateTimeActions
    {
        public static string GetCurrentDate() => DateTime.Now.ToString("yyyy-MM-dd");
        public static string GetCurrentDate(string dateFormat) => DateTime.Now.ToString(dateFormat);
    }
}
