using NUnit.Framework;
using UserRegistration;

namespace ValidationTest
{
    public class Tests
    {
        [Test]
        public void User_Valid_name()
        {
            Validation valid = new Validation();
            bool Val = valid.ValidName("Mohan");
            Assert.IsTrue(Val);
        }
        [Test]
        public void User_Valid_Lastname()
        {
            Validation valid = new Validation();
            bool Val = valid.ValidLastName("Sahu");
            Assert.IsTrue(Val);
        }
        [Test]
        public void User_Valid_Email()
        {
            Validation valid = new Validation();
            bool Val = valid.ValidLastName("Mohan@123gmail.com");
            Assert.IsTrue(Val);
        }
    }
}