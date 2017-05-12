using NUnit.Framework;

public class NumberParserTest 
{
    private NumberParser parser = new NumberParser();

    [TestCase(150, "CL")]
    [TestCase(7, "VII")]
    [TestCase(9, "IX")]
    [TestCase(1601, "MDCI")]
    [TestCase(409, "CDIX")]
    public void ParsesArabicNumber(int input, string result)
    {
        string outpout = parser.ArabicToRoman(input);

        Assert.AreEqual(result, outpout);
    }

    [TestCase("III", 3)]
    [TestCase("LXIV", 64)]
    [TestCase("DLXXI", 571)]
    [TestCase("MXXIV", 1024)]
    [TestCase("MMDCXXIII", 2623)]
    public void ParsesRomanNumber(string input, int result)
    {
        int outpout = parser.RomanToArabic(input);

        Assert.AreEqual(result, outpout);
    }
}
