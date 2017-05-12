using NUnit.Framework;

public class CalculatorTest
{
    private Calculator calculator = new Calculator(new NumberParser());

    [TestCase("5", "2", false, "7")]
    [TestCase("122", "658", false, "780")]
    [TestCase("1312", "MCCCXLVIII", false, "2660")]
    [TestCase("122", "255", true, "CCCLXXVII")]
    [TestCase("3589", "23", true, "MMMDCXII")]
    public void ApplicateSum(string a, string b, bool romanOutpout, string result)
    {
        string outpout = calculator.Sum(a, b, romanOutpout);

        Assert.AreEqual(result, outpout);
    }

    [TestCase("1321", "CXX", true, "MCCI")]
    [TestCase("82", "76", true, "VI")]
    [TestCase("14", "22", false, "-8")]
    [TestCase("CMIX", "102", false, "807")]
    [TestCase("4", "2", false, "2")]
    public void AplicateSubstract(string a, string b, bool romanOutpout, string result)
    {
        string outpout = calculator.Substract(a, b, romanOutpout);

        Assert.AreEqual(result, outpout);
    }
}
