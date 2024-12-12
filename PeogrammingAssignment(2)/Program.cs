using Assignment_2_;

namespace PeogrammingAssignment_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Write a program that allows the user to enter a number then print it.


            //Console.WriteLine("Please Enter your Number");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The number is" + num);
            #endregion


            #region Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen


            //int x = 100;
            //int y = 50;
            ////Assign x=y
            //x = y;
            //Console.WriteLine("the value of x " + x);
            //Console.WriteLine("the value of y" + y);

            //// after modifcation  Y
            //y = 10;
            //Console.WriteLine("the value of x after Modify" + x);
            //Console.WriteLine("the value of y after modify " + y);

            // X is not Upadte Beacause x = y it is copy value but not copy References


            #endregion

            #region Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen


            // make object D1



            //Distance D1 = new Distance();
            //// assign value 
            //D1.x = 100;
            //D1.y = 50;

            //// make Object D2
            //Distance D2 = new Distance();

            //// assign D2 by D1
            //D2 = D1;

            //// Display value 
            //Console.WriteLine("the value of (D1)" + D1.x);
            //Console.WriteLine("the value of (D1)" + D1.y);


            //Console.WriteLine("the value of (D2)" + D2.x);
            //Console.WriteLine("the value of (D2)" + D2.y);

            //// update D1
            //D1.x = 5;
            //D1.y = 10;

            //Console.WriteLine("-------------after update-------------------");

            //Console.WriteLine("the value of (D1)" + D1.x);
            //Console.WriteLine("the value of (D1)" + D1.y);


            //Console.WriteLine("the value of (D2)" + D2.x);
            //Console.WriteLine("the value of (D2)" + D2.y);

            //// D2 is changed after change D1 beacause D2 copy refernces of D1
            //// D2 is changed after change D1 beacause D2 copy refernces of D1

            #endregion


        }
    }
}
