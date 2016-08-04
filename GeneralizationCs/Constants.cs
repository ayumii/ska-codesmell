using System;

namespace GeneralizationCs
{
    public class Constants
    {
        public static int SizeLength = 1;
        public static int CmdByteLength = 1;

        public static char Hex0X00 = (char) 0x00;
        public static char Hex0X01 = (char) 0x01;
        public static char Hex0X02 = (char) 0x02;
        public static char Hex0Xde = (char) 0xde;
        public static char Hex0Xad = (char) 0xad;
        public static char Hex0Xbe = (char) 0xbe;
        public static char Hex0Xef = (char) 0xef;

        public static char Dec48 = (char) 48;
        public static char Dec50 = (char) 50;
        public static char Dec53 = (char) 53;

        public static char[] Header = {Hex0Xde, Hex0Xad};
        public static char CommandChar0X01 = Hex0X01;
        public static char CommandChar0X02 = Hex0X02;
        public static char[] Footer = {Hex0Xbe, Hex0Xef};
    }
    

}
