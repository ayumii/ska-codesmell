using System.IO;

namespace GeneralizationCs
{
    public abstract class BaseCommand
    {
        protected abstract string RetrieveDetailString();

        protected abstract char RetrieveCommandChar();

        protected int Size => Constants.Header.Length + Constants.SizeLength + Constants.CmdByteLength +
                              Constants.Footer.Length + RetrieveDetailString().Length;
        public void Write(TextWriter writer)
        {
            writer.Write(Constants.Header);
            writer.Write(Size);
            writer.Write(RetrieveCommandChar());
            writer.Write(RetrieveDetailString());
            writer.Write(Constants.Footer);
        }
    }
}
