using NUnit.Framework;

namespace DataAccessLayer.Tests
{
    internal class TestHelicopterRepository
    {

        [Test]
        public void ReadFromFileCsv_WrongPath_ReturnFalse()
        {
            var repository = new HelicopterRepository();
            Assert.IsFalse(repository.ReadFromFileCsv(@"nput"));
        }

        [Test]
        public void ReadFromFileCsv_RightPathRightFormat_ReturnTrue()
        {
            var repository = new HelicopterRepository();
            Assert.IsTrue(repository.ReadFromFileCsv(@"E:\FPT_GST\Assigment_Airport\Data Input\Helicopters.csv"));
        }

    }
}
