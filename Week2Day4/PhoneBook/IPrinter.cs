using System.Collections.Generic;

namespace PhoneBook
{
    public interface IPrinter<T>
    {
        void PrintLineResult(List<T> list);
    }
}