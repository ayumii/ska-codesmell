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
            char[] knownGood = new char[] {(char)Constants.HEX_0xde, (char)Constants.HEX_0xad,
                                    (char)Constants.DEC_50,(char)Constants.DEC_48,
                                    (char)Constants.HEX_0x01,
                                    'b', 'a', 'b', (char)Constants.HEX_0x00,
                                    'c', 'a', 'r', 'd', 'i', 'n', 'a', 'l', 's', (char)Constants.HEX_0x00,
                                    (char)Constants.HEX_0xbe, (char)Constants.HEX_0xef};

            LoginDetail loginDetail = new LoginDetail("bab", "cardinals");
            LoginCommand cmd = new LoginCommand(loginDetail);
			StringWriter writer = new StringWriter();
			cmd.Write(writer);
            Assert.AreEqual(knownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);
		}
	}
}
