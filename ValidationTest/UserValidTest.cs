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
        [Test]
        public void User_Valid_Mobile()
        {
            Validation valid = new Validation();
            bool Val = valid.ValidMobile("91 7898625487");
            Assert.IsTrue(Val);
        }
            [Test]
            public void User_Valid_Password_Minmum_Eight_Char()
            {
                Validation valid = new Validation();
                bool Val = valid.ValidPasswordMinChar("Mohan123");
                Assert.IsTrue(Val);
            }
        [Test]
        public void User_Valid_Password_Include_One_Uppercase()
        {
            Validation valid = new Validation();
            bool Val = valid.ValidPasswordIncludeUpperCase("Mohan123");
            Assert.IsTrue(Val);
        }
        [Test]
        public void User_Valid_Password_Include_One_Numeric()
        {
            Validation valid = new Validation();
            bool Val = valid.ValidPasswordIncludeNumeric("Rajeshs8");
            Assert.IsTrue(Val);
        }
    }
    }
