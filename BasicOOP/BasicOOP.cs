namespace BasicOOP
{
    class BasicOOP
    {
        static void Main(string[] args)
        {
            // ******************** CAR OBJECT *********************

            // Car myCar = new Car("BMW", "BMW", 2022);
            // myCar.DisplayInfo();

            

            // UnderstandingStatic ob = new UnderstandingStatic();
            // int a = ob.num1 = 10;
            // int b = ob.num2 = 20;

            // ***************** ACCESSING STATIC METHOD  ****************
            // int result  = UnderstandingStatic.Add(a,b);
            // Console.WriteLine(result);

            // *************** ACCESSING PRIVATE PROPERTIES BY SETTER AND GETTER METHOD*************

            UnderstandingPrivateModifier ob = new UnderstandingPrivateModifier("Fuad", 22);
            // it does not work
            // Console.WriteLine($"My name is: {ob.name} and my age is: {ob.age}");

            //it works
            Console.WriteLine($"My name is: {ob.GetName()} and my age is: {ob.GetAge()}");

            //it does not work
            // ob.name = "Thuha";
            // Console.WriteLine($"My name is: {ob.GetName()} and my age is: {ob.GetAge()}");


            //it works
            ob.SetName("Thuha");
            ob.SetAge(50);
            Console.WriteLine($"My name is: {ob.GetName()} and my age is: {ob.GetAge()}");

        }
    }

    // ****************** CAR CLASS ***********************

    // public class Car
    //     {
            // *************** Properties *****************
    //         public string brand;
    //         public string model;
    //         public int year;

             // *************** Constructor **************
    //         public Car(string brand, string model, int year)
    //         {
    //             this.brand = brand;
    //             this.model = model;
    //             this.year = year;
    //         }

             // *************** Method ***************
    //         public void DisplayInfo()
    //         {
    //             Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
    //         }
    //     }

    // public class UnderstandingStatic{
        // ******************* Static properties *****************
        // public static int number1;
        // public static int number2;

        // ******************* STATIC METHOD *********************
        // public static int Add(int n, int m){
        //     return n+m;
        // }
        
    // }

    // ************** UNDERSTANDING PRIVATE MODIFIER AND DEFINE SETTER AND GETTER METHOD **************

    public class UnderstandingPrivateModifier{
        // ******************* Private properties *****************
        private string name;
        private int age;
        public UnderstandingPrivateModifier (string name, int age){
            this.name = name;
            this.age = age;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            name = newName;
        }

        public int GetAge()
        {
            return age;
        }
        public void SetAge(int newAge)
        {
            age = newAge;
        }



    }

}