using System.IO;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

	[TestFixture] public class LoginCommandTest 
	{
		[TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        [TestCase(9)]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]
        [TestCase(15)]
        [TestCase(16)]
        [TestCase(17)]
        [TestCase(18)]
        [TestCase(19)]
        [TestCase(20)]
        public void SentCorrectly(int index) {                   
            char[] knownGood = {(char)Constants.Hex0Xde, (char)Constants.Hex0Xad,
                                    (char)Constants.Dec50,(char)Constants.Dec48,
                                    (char)Constants.Hex0X01,
                                    'b', 'a', 'b', (char)Constants.Hex0X00,
                                    'c', 'a', 'r', 'd', 'i', 'n', 'a', 'l', 's', (char)Constants.Hex0X00,
                                    (char)Constants.Hex0Xbe, (char)Constants.Hex0Xef};

            LoginDetail loginDetail = new LoginDetail("bab", "cardinals");
            LoginCommand cmd = new LoginCommand(loginDetail);
			StringWriter writer = new StringWriter();
			cmd.Write(writer);
            Assert.AreEqual(knownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);
		}
	}
}
