using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClubActivity;

namespace ClubActivity_Fixture
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fixture_for_checking_Name()
        {
            Name name = new Name("Deependra", "", "Tripathi");
            string completeName = name.ToString();
            Assert.AreEqual("Deependra  Tripathi", completeName);
        }

        [TestMethod]
        public void Fixture_for_checking_Dob_and_Age()
        {
            Person person = new Person();
            person.DateOfBirth = new DateTime(1994, 07, 01);
            int age = person.Age;
            Assert.AreEqual(24, age);

        }
        [TestMethod]
        public void Fixture_for_creating_Bikers_Club()
        {
            Person person = new Person();
            person.Name = new Name("Deependra", "", "Tripathi");
            person.DateOfBirth = new DateTime(1994,05, 05);
            Person person2 = new Person();
            person2.Name = new Name("Suraj", "", "Narayan");
            person2.DateOfBirth = new DateTime(1995,05,10 );
            Person person3 = new Person();
            person3.Name = new Name("Deepu", "", "Tripathi");
            person3.DateOfBirth = new DateTime(2012, 10, 05);
            BikersClub bikerClub = new BikersClub();
            bikerClub.Enroll(person);
            bikerClub.Enroll(person2);
            bikerClub.Enroll(person3);
            Assert.AreEqual(2, bikerClub.GetMembers().Count);
        }

    }    
}
