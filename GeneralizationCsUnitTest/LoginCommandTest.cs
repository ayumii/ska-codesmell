using System.IO;
using System.Linq;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

	[TestFixture] public class LoginCommandTest 
	{
        private static char[] _knownGood = {Constants.Hex0Xde, Constants.Hex0Xad,
                                    Constants.Dec50, Constants.Dec48,
                                    Constants.Hex0X01,
                                    'b', 'a', 'b', Constants.Hex0X00,
                                    'c', 'a', 'r', 'd', 'i', 'n', 'a', 'l', 's', Constants.Hex0X00,
                                    Constants.Hex0Xbe, Constants.Hex0Xef};

        private static int _length = _knownGood.Length;
        private int[] _testCasesIndexes = Enumerable.Range(0, _length-1).ToArray();

        [Test,TestCaseSource("_testCasesIndexes")]
        public void SentCorrectly(int index) {                   
            LoginDetail loginDetail = new LoginDetail("bab", "cardinals");
            LoginCommand cmd = new LoginCommand(loginDetail);
			StringWriter writer = new StringWriter();
			cmd.Write(writer);
            Assert.AreEqual(_knownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);
		}
	}
}
