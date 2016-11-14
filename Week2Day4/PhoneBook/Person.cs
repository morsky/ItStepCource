namespace PhoneBook
{
    public class Person
    {
        public string Name { get; set; }

        public string Town { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", Name, Town, PhoneNumber);
        }
    }
}