using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhoneBook.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CheckIfPhoneBookIsNotNull()
        {
            PhoneBook book = new PhoneBook();

            Assert.IsNotNull(book);
        }

        [TestMethod]
        public void CheckIfPersonObjectCanBeAddedToPhoneBook()
        {
            PhoneBook book = new PhoneBook();
            Person person = new Person();
            person.Name = "Mimi";
            person.Town = "Plovdiv";
            person.PhoneNumber = "000 111 222";

            book.Add(person);

            Assert.IsNotNull(book);
        }
    }
}