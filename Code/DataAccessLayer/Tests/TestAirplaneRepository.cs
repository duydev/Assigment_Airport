using NUnit.Framework;

namespace DataAccessLayer.Tests
{
    internal class TestAirplaneRepository
    {

        [Test]
        public void ReadFromFileCsv_WrongPath_ReturnFalse()
        {
            var repository = new AirplaneRepository();
            Assert.IsFalse(repository.ReadFromFileCsv(@"nput"));
        }

        [Test]
        public void ReadFromFileCsv_RightPathRightFormat_ReturnTrue()
        {
            var repository = new AirplaneRepository();
            Assert.IsTrue(repository.ReadFromFileCsv(@"E:\FPT_GST\Assigment_Airport\Data Input\Airplanes.csv"));
        }


    }
}
