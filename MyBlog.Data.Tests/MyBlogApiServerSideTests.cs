using NUnit.Framework;

namespace MyBlog.Data.Tests
{
    [TestFixture]
    public class MyBlogApiServerSideTests
    {
        private MyBlogApiServerSide api;

        [SetUp]
        public void Setup()
        {
            api = new MyBlogApiServerSide()
        }

        [TearDown]
        public void Teardown()
        {
        }
    }
}