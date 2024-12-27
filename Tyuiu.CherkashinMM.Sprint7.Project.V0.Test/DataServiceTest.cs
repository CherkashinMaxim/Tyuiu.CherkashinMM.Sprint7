using Tyuiu.CherkashinMM.Sprint7.Project.V0.Lib;

namespace Tyuiu.CherkashinMM.Sprint7.Project.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _dataService;

        [TestInitialize]
        public void Setup()
        {
            _dataService = new DataService();
        }


        [TestMethod]
        public void ReadTable_ShouldReturnCorrectData_WhenFileIsValid()
        {
            string tempFile = Path.GetTempFileName();
            File.WriteAllText(tempFile, "Name;Age\nJohn;30\nAlice;25");

            try
            {
                List<string[]> result = _dataService.readTable(tempFile);

                Assert.AreEqual(2, result.Count);
                CollectionAssert.AreEqual(new[] { "John", "30" }, result[0]);
                CollectionAssert.AreEqual(new[] { "Alice", "25" }, result[1]);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void SaveToFile_ShouldCreateFileWithCorrectContent()
        {
            string tempFile = Path.GetTempFileName();
            string[] columnNames = { "Name", "Age" };
            string[,] data =
            {
                { "John", "30" },
                { "Alice", "25" }
            };

            try
            {
                _dataService.SaveToFile(tempFile, columnNames, data);

                string[] fileContent = File.ReadAllLines(tempFile);
                Assert.AreEqual("Name;Age", fileContent[0]);
                Assert.AreEqual("John;30", fileContent[1]);
                Assert.AreEqual("Alice;25", fileContent[2]);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void ReadTable_ShouldHandleEmptyFileGracefully()
        {
            string tempFile = Path.GetTempFileName();

            try
            {
                List<string[]> result = _dataService.readTable(tempFile);

                Assert.AreEqual(0, result.Count);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void SaveToFile_ShouldHandleEmptyDataGracefully()
        {
            string tempFile = Path.GetTempFileName();
            string[] columnNames = { "Name", "Age" };
            string[,] data = new string[0, 0];

            try
            {
                _dataService.SaveToFile(tempFile, columnNames, data);

                string[] fileContent = File.ReadAllLines(tempFile);
                Assert.AreEqual(1, fileContent.Length);
                Assert.AreEqual("Name;Age", fileContent[0]);
            }
            finally
            {
                File.Delete(tempFile);
            }
        }
    }
}