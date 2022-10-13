namespace TDD;

 [TestFixture]
public class Tests
{
    // create Object for maths
    Maths operation = null;

    [SetUp]
    public void Setup()
    {
        // Intialize Objects 
        operation = new Maths();
    }

    [Test]
    public void Test1()
    {
        //
        int result = operation.Addition(11,11);
        Assert.That(result,Is.EqualTo(22));
        
    }

    [TestCase (20,20,40)]
    [TestCase(3,2,5)]
    public void AdditionCorrect (int number1, int number2,int result)
    {
        int output = operation.Addition(number1,number2);
        Assert.AreEqual(output,result);
    }


    [TestCase(1.1,2.1,3.2)]
    public void AdditionCorrect (double number1, double number2,double result)
    {
        double output = operation.Addition(number1,number2);
        Assert.AreEqual(output,result);
    }
}