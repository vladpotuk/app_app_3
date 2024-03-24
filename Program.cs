namespace EventCSharp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person(string firstName, string lastName, int age, string address, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    public static class PersonExtensions
    {
        public static Person FindOldest(this IEnumerable<Person> people)
        {
            return people.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public static Person FindYoungest(this IEnumerable<Person> people)
        {
            return people.OrderBy(p => p.Age).FirstOrDefault();
        }

        public static double AverageAge(this IEnumerable<Person> people)
        {
            return people.Select(p => p.Age).Average();
        }

        public static IEnumerable<Person> SearchByName(this IEnumerable<Person> people, string searchTerm)
        {
            searchTerm = searchTerm.ToLower();
            return people.Where(p => p.FirstName.ToLower().Contains(searchTerm) || p.LastName.ToLower().Contains(searchTerm));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
        {
            new Person("John", "Doe", 30, "123 Main St", "123-456-7890", "john@example.com"),
            new Person("Jane", "Smith", 25, "456 Elm St", "987-654-3210", "jane@example.com"),
            new Person("Michael", "Johnson", 40, "789 Oak St", "456-789-0123", "michael@example.com"),
            new Person("Emily", "Davis", 35, "321 Pine St", "789-012-3456", "emily@example.com")
        };

            Person oldestPerson = people.FindOldest();
            Console.WriteLine($"Найстарша людина: {oldestPerson.FirstName} {oldestPerson.LastName}, вік {oldestPerson.Age} років");

            Person youngestPerson = people.FindYoungest();
            Console.WriteLine($"Наймолодша людина: {youngestPerson.FirstName} {youngestPerson.LastName}, вік {youngestPerson.Age} років");

            double averageAge = people.AverageAge();
            Console.WriteLine($"Середній вік людей: {averageAge} років");

            string searchName = "John";
            var searchResult = people.SearchByName(searchName);
            Console.WriteLine($"Результати пошуку за ім'ям або прізвищем '{searchName}':");
            foreach (var person in searchResult)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}, {person.Age} років");
            }
        }
    }
}