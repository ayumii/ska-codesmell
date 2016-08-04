using System.IO;
using System.Linq;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

	[TestFixture] public class LoginCommandTest 
	{
        private static char[] _KnownGood = {(char)Constants.Hex0Xde, (char)Constants.Hex0Xad,
                                    (char)Constants.Dec50,(char)Constants.Dec48,
                                    (char)Constants.Hex0X01,
                                    'b', 'a', 'b', (char)Constants.Hex0X00,
                                    'c', 'a', 'r', 'd', 'i', 'n', 'a', 'l', 's', (char)Constants.Hex0X00,
                                    (char)Constants.Hex0Xbe, (char)Constants.Hex0Xef};

        private static int _Length = _KnownGood.Length;
        private int[] _TestCasesIndexes = Enumerable.Range(0, _Length-1).ToArray();

        [Test,TestCaseSource("_TestCasesIndexes")]
        public void SentCorrectly(int index) {                   
            LoginDetail loginDetail = new LoginDetail("bab", "cardinals");
            LoginCommand cmd = new LoginCommand(loginDetail);
			StringWriter writer = new StringWriter();
			cmd.Write(writer);
            Assert.AreEqual(_KnownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);
		}
	}
}
