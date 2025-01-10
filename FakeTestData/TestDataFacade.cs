using FakeTestData.TestDataActions;

namespace FakeTestData
{
    public class TestDataFacade
    {
        public PersonActions Person
        {
            get => new PersonActions();
        }

        public DateTimeActions DateTime
        {
            get => new DateTimeActions();
        }

        public RandomNumbersActions RandomNumbers
        {
            get => new RandomNumbersActions();
        }
    }
}