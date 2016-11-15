namespace PhoneBook
{
    public interface IParser
    {
        void Parse(string line, PhoneBook book);
        //void Parse(string line);
    }
}