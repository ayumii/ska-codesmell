using System.IO;
using GeneralizationCs;
using NUnit.Framework;

namespace GeneralizationCsUnitTest
{

	[TestFixture] public class LoginCommandTest 
	{
		[Test] public void SentCorrectly() {                   
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

			for( int i = 0; i < knownGood.Length; i++ ) {
				Assert.AreEqual(knownGood[i], writer.ToString()[i],  "comparison failed at byte number " + i);
			}
		}
	}
}
