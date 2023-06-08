namespace RepeatOperationBasicOOP
{
    class RepeatOperationBasicOOP
    {
        static void Main(string[] args)
        {
            //******************* Repeat Operation Basic OOP *******************

            // ********************   FOR LOOP  ******************
            // int sum = 0;

            // for (int i = 1; i <= 10; i++)
            // {
            //     sum += i;
            // }

            // Console.WriteLine("The sum of the first 10 numbers is: " + sum);


            // ********************   WHILE LOOP (INTEGER REVERSAL)   ******************
            // int number = 12345;
            // int reversed = 0;

            // while (number != 0)
            // {
            //     reversed = (reversed * 10) + (number % 10);
            //     number /= 10;
            // }

            // Console.WriteLine("Reversed Number: " + reversed);



            // ********************   DO WHILE LOOP (FIZZBUZZ)   ******************
            // int number = 1;

            // do
            // {
            //     if (number % 3 == 0 && number % 5 == 0)
            //     {
            //         Console.WriteLine("FizzBuzz");
            //     }
            //     else if (number % 3 == 0)
            //     {
            //         Console.WriteLine("Fizz");
            //     }
            //     else if (number % 5 == 0)
            //     {
            //         Console.WriteLine("Buzz");
            //     }
            //     else
            //     {
            //         Console.WriteLine(number);
            //     }

            //     number++;
            // } while (number <= 100);


            //*************** OOP OBJECT ****************
            // Person p1 = new Person("Fuad Hasan", 22);
            // p1.name = "Fuad Hasan";
            // p1.age = 22;
            // p1.details();
            

        }
    }


    // ******************** OOP CLASS *******************
    // public class Person
    //     {   
    //         public string name;
    //         public int age;

    //         public Person (string name, int age){
    //             this.name = name;
    //             this.age = age;
    //         }
    //         public void details()
    //         {
    //             Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");
    //         }
    //     }
}