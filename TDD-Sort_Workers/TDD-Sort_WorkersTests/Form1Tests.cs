using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Sort_Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Sort_Workers.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        // ------------------------------------- Test the 6 execution paths of func - TaxCal() -------------------------------------

        // Testing all the 6 execution paths by randomly Entering a salary in the appropriate salary range according to its tax bracket,
        // calculate the appropriate tax according to the table 
        // and check whether the function performs the calculation correctly by comparing the requested tax with the result of the function.


        [TestMethod()]
        public void TaxCal_FirstTaxBrackets_Test()
        {
            // Arrange
            Random random = new Random();

            var temp = new Form1();
            float random_salary1 = random.Next(0, 6450);
            int expectedTax1 = (int)(random_salary1 * 0.1);

            // Act
            int calcTax1 = (int)temp.TaxCal((int)random_salary1);

            // Assert
            Assert.AreEqual(expectedTax1, calcTax1);
        }

        [TestMethod()]
        public void TaxCal_SecondTaxBrackets_Test()
        {
            // Arrange
            Random random = new Random();

            var temp = new Form1();
            float random_salary2 = random.Next(6451, 9240);
            int expectedTax2 = (int)(random_salary2 * 0.14);

            // Act
            int calcTax2 = (int)temp.TaxCal((int)random_salary2);

            // Assert
            Assert.AreEqual(expectedTax2, calcTax2);
        }

        [TestMethod()]
        public void TaxCal_ThirdTaxBrackets_Test()
        {
            // Arrange
            Random random = new Random();

            var temp = new Form1();
            float random_salary3 = random.Next(9241, 14840);
            int expectedTax3 = (int)(random_salary3 * 0.2);

            // Act
            int calcTax3 = (int)temp.TaxCal((int)random_salary3);

            // Assert
            Assert.AreEqual(expectedTax3, calcTax3);
        }

        [TestMethod()]
        public void TaxCal_FourthTaxBrackets_Test()
        {
            // Arrange
            Random random = new Random();

            var temp = new Form1();
            float random_salary4 = random.Next(14841, 20620);
            int expectedTax4 = (int)(random_salary4 * 0.31);

            // Act
            int calcTax4 = (int)temp.TaxCal((int)random_salary4);

            // Assert
            Assert.AreEqual(expectedTax4, calcTax4);
        }

        [TestMethod()]
        public void TaxCal_FifthTaxBrackets_Test()
        {
            // Arrange
            Random random = new Random();

            var temp = new Form1();
            float random_salary5 = random.Next(20621, 42910);
            int expectedTax5 = (int)(random_salary5 * 0.35);

            // Act
            int calcTax5 = (int)temp.TaxCal((int)random_salary5);

            // Assert
            Assert.AreEqual(expectedTax5, calcTax5);
        }

        [TestMethod()]
        public void TaxCal_SixthTaxBrackets_Test()
        {
            // Arrange
            Random random = new Random();

            var temp = new Form1();
            float random_salary6 = random.Next(42911, 50000);
            int expectedTax6 = (int)(random_salary6 * 0.47);

            // Act
            int calcTax6 = (int)temp.TaxCal((int)random_salary6);

            // Assert
            Assert.AreEqual(expectedTax6, calcTax6);
        }

        // ------------------------------------- Test the func - Bubble_Sort() -------------------------------------

        // The test includes whether: 
        // The array did not lose records. 
        // The array is indeed sorted.

        // Note: According to the C # documentation - A test method must meet the following requirements:
        // 1) The method must be decorated with the [TestMethod] attribute.
        // 2) The method must return void.
        // 3) The method cannot have parameters

        // So there is no need to check in C # language that the pony returns something or not because it is certainly Void!



        [TestMethod()]
        public void Sort_IsFound_Test()
        {
            // Arrange
            var temp = new Form1();
            Worker w1 = new Worker(111111111, "פרטי1", "משפחה1", 5000);
            Worker w2 = new Worker(222222222, "פרטי2", "משפחה2", 8000);
            Worker w3 = new Worker(333333333, "פרטי3", "משפחה3", 12000);
            Worker w4 = new Worker(444444444, "פרטי4", "משפחה4", 20000);
            Worker w5 = new Worker(555555555, "פרטי5", "משפחה5", 40000);
            Worker w6 = new Worker(666666666, "פרטי6", "משפחה6", 50000);

            // Act
            List<Worker> workers = new List<Worker>(6) { w1, w3, w5, w2, w4, w6 };
            Worker[] arrWorkers = workers.Cast<Worker>().ToArray();
            // temp.Bubble_Sort(arrWorkers);                                ***** Bubble Sort *****
            temp.Quick_Sort(arrWorkers, 0, 5); //                           ***** Quick Sort *****
            workers = arrWorkers.ToList();

            // Assert
            Assert.IsTrue(workers.Contains(w1) && workers.Contains(w2) && workers.Contains(w3) && workers.Contains(w4) && workers.Contains(w5) && workers.Contains(w6));
        }

        [TestMethod()]
        public void Sort_IsSorted_Test()
        {
            // Arrange
            var temp = new Form1();
            Worker w1 = new Worker(111111111, "פרטי1", "משפחה1", 5000);
            Worker w2 = new Worker(222222222, "פרטי2", "משפחה2", 8000);
            Worker w3 = new Worker(333333333, "פרטי3", "משפחה3", 12000);
            Worker w4 = new Worker(444444444, "פרטי4", "משפחה4", 20000);
            Worker w5 = new Worker(555555555, "פרטי5", "משפחה5", 40000);
            Worker w6 = new Worker(666666666, "פרטי6", "משפחה6", 50000);
            List<Worker> ExpectedWorkers = new List<Worker>(6) { w1, w2, w3, w4, w5, w6 };

            // Act
            List<Worker> workers = new List<Worker>(6) { w1, w3, w5, w2, w4, w6 };
            Worker[] arrWorkers = workers.Cast<Worker>().ToArray();
            // temp.Bubble_Sort(arrWorkers);                                ***** Bubble Sort *****
            temp.Quick_Sort(arrWorkers, 0, 5); //                           ***** Quick Sort *****
            workers = arrWorkers.ToList();

            // Assert
            Assert.IsTrue(ExpectedWorkers.SequenceEqual(workers));
        }
    }
}