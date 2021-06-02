using NUnit.Framework;

namespace HW.API.Test
{
    [TestFixture]
    public class Tests
    {
        IMessageProvider _messageProvider;
        string _expectedResult = "Hello World";

        [Test]
        public void ConsoleMessageProvider_Message_Matches_ExpectedResult()
        {
            _messageProvider = new ConsoleMessageProvider();
            Assert.AreEqual(_expectedResult, _messageProvider.GetMessage());
        }
    }
}