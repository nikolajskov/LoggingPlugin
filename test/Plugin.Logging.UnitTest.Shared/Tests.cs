using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace Plugin.Logging.UnitTest
{
    [TestFixture]
    public class TestsSample
    {

        [SetUp]
        public void Setup() { }


        [TearDown]
        public void Tear() { }

        [Test]
        public void Verbose()
        {
            Logging.Verbose("Verbose message");
        }

        [Test]
        public void VerboseWithException()
        {
            Logging.Verbose("Verbose message", new System.Exception("Exception message"));
        }

        [Test]
        public void Debug()
        {
            Logging.Debug("Debug message");
        }

        [Test]
        public void DebugWithException()
        {
            Logging.Debug("Debug message", new System.Exception("Exception message"));
        }

        [Test]
        public void Info()
        {
            Logging.Info("Info message");
        }

        [Test]
        public void InfoWithException()
        {
            Logging.Info("Info message", new System.Exception("Exception message"));
        }

        [Test]
        public void Warning()
        {
            Logging.Warning("Warning message");
        }

        [Test]
        public void WarningWithException()
        {
            Logging.Warning("Warning message", new System.Exception("Exception message"));
        }

        [Test]
        public void Error()
        {
            Logging.Error("Error message");
        }

        [Test]
        public void ErrorWithException()
        {
            Logging.Error("Error message", new System.Exception("Exception message"));
        }

        [Test]
        public void Fatal()
        {
            Logging.Fatal("Fatal message");
        }

        [Test]
        public void FatalWithException()
        {
            Logging.Fatal("Fatal message", new System.Exception("Exception message"));
        }
    }
}
