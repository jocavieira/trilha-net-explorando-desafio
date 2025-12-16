namespace HotelChallenge.Models
{  
    public class Person
    {
        public Person() { }

        public Person(string name)
        {
            FirstName = name;
            LastName = "";
        }

        public Person(string name, string lastName)
        {
            FirstName = name;
            LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}".ToUpper();
    }
}