using NUnit.Framework;

namespace DataAccessLayer.Tests
{
    internal class TestAirportRepository
    {
        [Test]
        public void ReadFromFileCsv_WrongPath_ReturnFalse()
        {
            var repository = new AirportRepository();
            Assert.IsFalse(repository.ReadFromFileCsv(@"nput"));
        }

        [Test]
        public void ReadFromFileCsv_RightPathRightFormat_ReturnTrue()
        {
            var repository = new AirportRepository();
            Assert.IsTrue(repository.ReadFromFileCsv(@"E:\FPT_GST\Assigment_Airport\Data Input\Airports.csv"));
        }

    }
}
