using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests_Console.Tests
{
    public static class PracticeFunctionTest
    {
        // Naming convention - ClassName_MethodName_ExpectedResult
        public static void PracticeFunction_ReturnsSomethingIfZero_ReturnString()
        {
            try
            {
                //Arrange
                int num = 0;
                PracticeFunction practiceFunction = new PracticeFunction();
                //Act
                string result = practiceFunction.ReturnsSomethingIfZero(num);
                //Assert
                if (result == "Something!")
                {
                    Console.WriteLine("PASSED: PracticeFunction.ReturnsSomethingIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: PracticeFunction.ReturnsSomethingIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }    
    }
}
