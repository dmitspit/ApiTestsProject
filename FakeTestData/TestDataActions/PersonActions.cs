using Bogus;

namespace FakeTestData.TestDataActions
{
    public class PersonActions
    {
        protected Faker faker = new Faker();

        public string GetFirstName() => faker.Name.FirstName();

        public string GetLastName() => faker.Name.LastName();

        public string GetFullName() => faker.Name.FullName();
    }
}
