namespace PhoneBook
{
    public interface IParser
    {
        PhoneBook Parse(IReader reader);
    }
}