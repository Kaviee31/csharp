using PersonLibrary;
namespace PersonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Kavitha";
            person.LastName = "Shanmugam";
            person.BirthDate = DateTime.Parse("2001-12-31");
            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.GetAge());
            Console.WriteLine(person.IsTodayBirthday());

            Person person1 = new Person("kavi", "kkl", DateTime.Parse("2027-01-14"));
            Console.WriteLine(person1.GetFullName());
            Console.WriteLine(person1.GetAge());
            Console.WriteLine(person1.IsTodayBirthday());


        }
    }
}
