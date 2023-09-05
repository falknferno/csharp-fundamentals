using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstApplication;

namespace MyFirstTestProject
{
    [TestClass]
    public class Lesson10Test
    {
        [TestMethod]
        public void FirstName_LastName_ZipCode_Verify()
        {
            // arrange
            string firstName = "George";
            string lastName = "Washington";
            int zipCode = 64119;
            Lesson10 myLesson10 = new Lesson10(firstName, lastName, zipCode);

            // act - nothing for this one

            // assert
            Assert.AreEqual(firstName, myLesson10.Firstname);
            Assert.AreEqual(lastName, myLesson10.LastName);
            Assert.AreEqual(zipCode, myLesson10.Zipcode);
        }

        [TestMethod]
        public void IdVerify()
        {
            int id = 608;
            Lesson10 myLesson10 = new Lesson10();
            int ID = id;

            Assert.AreEqual(608, myLesson10.Id);
        }

       
    }

}