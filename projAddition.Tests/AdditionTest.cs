using projAddition;
namespace prj.Addition.test;

public class AdditionTest
{
    [Fact]
    public void Check20Plus10is30Test()
    {
        //Arrange
        Calculator CalcObj = new Calculator();
        //Act
        int result = CalcObj.Add(20,10);
        //Assert
        Assert.Equal(30,result);  
    }
    [Fact]
    public void Check20SubractedBy10is10Test()
    {
        //Arrange
        Calculator CalcObj = new Calculator();
        //Act
        int result = CalcObj.Sub(20,10);
        //Assert
        Assert.Equal(10,result);  
    }
    [Fact]
    public void Check20Multiplied10is200Test()
    {
        //Arrange
        Calculator CalcObj = new Calculator();
        //Act
        int result = CalcObj.Mul(20,10);
        //Assert
        Assert.Equal(200,result);  
    }
    [Fact]
    public void Check20DividedBy10is2Test()
    {
        //Arrange
        Calculator CalcObj = new Calculator();
        //Act
        int result = CalcObj.Div(20,10);
        //Assert
        Assert.Equal(2,result);  
    }
}