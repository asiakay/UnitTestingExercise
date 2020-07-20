using System;
namespace UnitTestingExercise.tests

{
    public class UnitTestMethods
    {
        //done
        // Make sure your references are set properly
        // Right-click on Dependencies in your .Tests project
        //and set your reference



        // Create an Add method that passes 3 integers

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        //

        // Create an Add method that passes 3 integers

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }


        // Create a Multiply method that passes 2 integers

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }



        // Create a Divide method that passes 2 integers

        public int Divide(int num1, int num2, int expected)
        {
            return num1 / num2;
        }




            //try
            //{
            //    return  num1 / num2;
            //}
            //catch
            //{
            //    DivideByZeroException exception)
            //        {
            //        Debug.WriteLine(exception.Message);
            //    }




            }

        //// Create 2 methods that will utilize the [Fact] tests you wrote

        //{
        //    throw new NotImplementedException();
        //}

        //public int Divide(int num1, int num2, int expected)
        //{
        //    throw new NotImplementedException();
        //}
    }

