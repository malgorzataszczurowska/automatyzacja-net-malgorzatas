using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MatematykaTest

    {
        // fact - dodano using xunit żeby vs widziało fact
        [Fact]

        //musi byc public bo inaczej nie będzie wudzialo nic z zewnątrz i voi  bo nie może nic nam zwracać
        //nazwa testu musi stricte odpowiadać temu co ma test wykonywać, jeśli nie można sensownie opisać nazwy testu tzn że może test jest za duży

        public void Method_add_return_sum_of_given_values()

        {
            // arrange
            Matematyka math = new Matematyka();

            // act
            double result = math.Add(10, 20);

            // assert
            Assert.Equal(30, result);

        }
        [Fact]
        public void Method_substract_return_sum_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            // act
            double result = math.Substract(15, 30);

            // assert
            Assert.Equal(-15, result);
        }
        [Fact]
        public void Method2_substract_return_sum_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            // act
            double result = math.Substract(60, 30);

            // assert
            Assert.Equal(30, result);
        }
        [Fact]
        public void Method_multiply_return_sum_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            // act
            double result = math.Multiply(2, 4);

            // assert
            Assert.Equal(8, result);

        }
        [Fact]
        public void Method2_multiply_return_sum_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            // act
            double result = math.Multiply(80, 1);

            // assert
            Assert.Equal(80, result);

        }
        [Fact]
        public void Method_divide_return_sum_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            // act
            double result = math.Divide(40, 2.5);

            // assert
            Assert.Equal(16, result);
        }
        [Fact]
        public void Method2_divide_return_sum_of_given_values()
        {
            // arrange
            Matematyka math = new Matematyka();

            // act
            double result = math.Divide(40, -2);

            // assert
            Assert.Equal(-20, result);

        }
    }
}