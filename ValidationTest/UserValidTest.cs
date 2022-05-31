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
    }
}