using Microsoft.VisualStudio.TestTools.UnitTesting;
using otus_architecture_lab_8;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        #region Nested classes

        class LoggerMock : ILogger
        {
            public void Dispose() {}

            public void Log(string message)
            {
                LastMessage = message;
            }
            
            public string LastMessage = null;
        }

        #endregion



        #region Tests

        [TestMethod]
        public void FileParserXmlTest()
        {
            LoggerMock logger = new LoggerMock();
            SimpleServiceLocator.Instance.RegisterService<ILogger>(logger);

            FileParserXml p = new FileParserXml();

            p.Handle("test.xml");
            Assert.IsTrue(logger.LastMessage.Contains("FileParserXml parce"));

            p.Handle("test.obj");
            Assert.IsTrue(logger.LastMessage.Contains("Can't parce file"));

            SimpleServiceLocator.Instance.Dispose();
        }


        [TestMethod]
        public void FileParserTxtTest()
        {
            LoggerMock logger = new LoggerMock();
            SimpleServiceLocator.Instance.RegisterService<ILogger>(logger);

            FileParserTxt p = new FileParserTxt();

            p.Handle("test.txt");
            Assert.IsTrue(logger.LastMessage.Contains("FileParserTxt parce"));

            p.Handle("test.obj");
            Assert.IsTrue(logger.LastMessage.Contains("Can't parce file"));

            SimpleServiceLocator.Instance.Dispose();
        }


        [TestMethod]
        public void FileParserCsvTest()
        {
            LoggerMock logger = new LoggerMock();
            SimpleServiceLocator.Instance.RegisterService<ILogger>(logger);

            FileParserCsv p = new FileParserCsv();

            p.Handle("test.csv");
            Assert.IsTrue(logger.LastMessage.Contains("FileParserCsv parce"));

            p.Handle("test.obj");
            Assert.IsTrue(logger.LastMessage.Contains("Can't parce file"));

            SimpleServiceLocator.Instance.Dispose();
        }


        [TestMethod]
        public void FileParserJsonTest()
        {
            LoggerMock logger = new LoggerMock();
            SimpleServiceLocator.Instance.RegisterService<ILogger>(logger);

            FileParserJson p = new FileParserJson();

            p.Handle("test.json");
            Assert.IsTrue(logger.LastMessage.Contains("FileParserJson parce"));

            p.Handle("test.obj");
            Assert.IsTrue(logger.LastMessage.Contains("Can't parce file"));

            SimpleServiceLocator.Instance.Dispose();
        }

        #endregion
    }
}
