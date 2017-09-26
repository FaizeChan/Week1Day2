using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //what data types have we talked about so far?
            //An int is a whole number (no decimals)
            //a string is a collection of characters

            char firstInitial = 'D';
            //Characters or chars are single letters or numbers
            //or symbols

            bool isTired = true;
            //Boolean or bool means true or false

            //other number data types
            float number = 2.164403304907294849383961032f;
            decimal partialNum = 2.164403304907294849383961032m;
            double someNumber = 2.164403304907294849383961032d;

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            //Now, let's tslk about operators!
            //ARITNMITIC OPERATORS
            // + adds two operands
            // - Subtracts second operand from the first
            // * Multiplies both operands
            // / Divides first operand by the second operand
            // % - Modules - divides and checks remainder
            // ++ Increments operator by one and is used for ints
            // -- Decrements operator by one 
            // == Checks if the values two operators are equal
            // and if they are, returns bool true
            // != Checks if the values of the two operands are not equal
            // or not, and if values of two operands are not equal, returns
            // bool true.

            int jarrydAge = 29;
            int danielAge = 32;
            Console.WriteLine(jarrydAge == danielAge);

            /*
             *  > Checks if the value of the left operand is
             *  greater than the value of the right operand, and
             *  if yes then the condition is true
             *  
             *  < Checks if the value of the left operand is
             *  less than the value of the right operand, and
             *  if yes then condition is true
             *  
             *  >= Checks if the value of left operand is
             *  less than or equal to the value of the right
             *  operand and if yes then condition becomes true
             */

            //LOGICAL OPERATORS
            /*
             * && we call AND operator. If both the operands are
             * non zero thaen condition becomes true.
             *
             * || we call OR operator. If any of the two operands
             * is non zero then condition becomes true.
             *
             * | we call NOT operator. This is used to reverse
             * the logical state of the operand. If a condition is true
             * then Logical NOT operator will make false.
             */











         }
    }
}
