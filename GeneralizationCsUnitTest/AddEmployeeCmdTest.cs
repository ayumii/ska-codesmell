using System.IO;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

	[TestFixture]
    public class AddEmployeeCmdTest
	{
		[Test]
        public void SentCorrectly() {
            char[] knownGood = {(char)Constants.HEX_0xde, (char)Constants.HEX_0xad, (char)Constants.DEC_53, (char)Constants.DEC_50, (char)Constants.HEX_0x02,
                                    'F', 'r', 'e', 'd', ' ', 'B', 'r', 'o', 'o', 'k', 's', (char)Constants.HEX_0x00,
                                    '1', '2', '3', ' ', 'M', 'y', ' ', 'H', 'o', 'u', 's', 'e', (char)Constants.HEX_0x00,
                                    'S', 'p', 'r', 'i', 'n', 'g', 'f', 'i', 'e', 'l', 'd', (char)Constants.HEX_0x00,
                                    'I', 'L', (char)Constants.HEX_0x00,
                                    '7', '2', '0', '0', '0', (char)Constants.HEX_0x00,
                                    (char)Constants.HEX_0xbe, (char)Constants.HEX_0xef};

            EmployeeDetail employeeDetail = new EmployeeDetail("Fred Brooks", "123 My House", "Springfield", "IL", "72000");
			AddEmployeeCmd cmd = new AddEmployeeCmd(employeeDetail);
			StringWriter writer = new StringWriter();
			cmd.Write(writer);

			for( int i = 0; i < knownGood.Length; i++ ) {
				Assert.AreEqual(knownGood[i], writer.ToString()[i], "comparison failed at byte number " + i );
			} 

		}
	}
}
