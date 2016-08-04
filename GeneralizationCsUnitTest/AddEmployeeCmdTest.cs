using System.IO;
using System.Linq;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

	[TestFixture]
    public class AddEmployeeCmdTest
	{
        private static char[] _KnownGood = {(char)Constants.Hex0Xde, (char)Constants.Hex0Xad,
                                (char)Constants.Dec53, (char)Constants.Dec50,
                                (char)Constants.Hex0X02,
                                'F', 'r', 'e', 'd', ' ', 'B', 'r', 'o', 'o', 'k', 's', (char)Constants.Hex0X00,
                                '1', '2', '3', ' ', 'M', 'y', ' ', 'H', 'o', 'u', 's', 'e', (char)Constants.Hex0X00,
                                'S', 'p', 'r', 'i', 'n', 'g', 'f', 'i', 'e', 'l', 'd', (char)Constants.Hex0X00,
                                'I', 'L', (char)Constants.Hex0X00,
                                '7', '2', '0', '0', '0', (char)Constants.Hex0X00,
                                (char)Constants.Hex0Xbe, (char)Constants.Hex0Xef};

	    private static int _Length = _KnownGood.Length;
	    private int[] _TestCasesIndexes = Enumerable.Range(0, _Length-1).ToArray();
        
        [Test, TestCaseSource("_TestCasesIndexes")]
        public void SentCorrectly(int index) {
            EmployeeDetail employeeDetail = new EmployeeDetail("Fred Brooks", "123 My House", "Springfield", "IL", "72000");
			AddEmployeeCmd cmd = new AddEmployeeCmd(employeeDetail);
			StringWriter writer = new StringWriter();
			cmd.Write(writer);
            Assert.AreEqual(_KnownGood[index], writer.ToString()[index], "comparison failed at byte number " + index);
        }
	}
}
