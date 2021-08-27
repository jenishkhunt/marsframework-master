using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Common
        {

            [Test]
            public void ShareSkill()
            {
                Skills obj = new Skills(driver);
                obj.AddSkills();

            }
            [Test]
            public void ViewListing()
            {
                ManageListings obj2 = new ManageListings(driver);
                obj2.ViewManageListing();
            }
            [Test]
            public void EditListing()
            {
                ManageListings obj2 = new ManageListings(driver);
                obj2.EditManageListing();
            }
            [Test]
            public void DeleteListing()
            {
                ManageListings obj2 = new ManageListings(driver);
                obj2.DeleteManageListing();
            }



        }
    }
}