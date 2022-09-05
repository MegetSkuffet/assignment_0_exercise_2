namespace exercise_2.tests;
using exercise0;

public class exercisetests
{
    [Fact]
    public void confim_it_is_a_leapyear()
    {
        // Arrange
        var sut = new LeapYear();  

        // Act
       var output = sut.IsLeapYear(2012);

        // Assert
       output.Should().Be("yay");
    }
}