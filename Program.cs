using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic_Class_With_Instance_Method bcwim = new Basic_Class_With_Instance_Method();
            bcwim.RunExercise();

            Instance_Variables iv = new Instance_Variables();
            iv.RunExercise();

            More_Methods mm = new More_Methods();
            mm.RunExercise();

            Access_Control ac = new Access_Control();
            ac.RunExercise();

            Overloading_Create_Your_Own ocyo = new Overloading_Create_Your_Own();
            ocyo.RunExercise();

            Constructors_Exercise ce = new Constructors_Exercise();
            ce.RunExercise();

            Scope_Of_Variables sov = new Scope_Of_Variables();
            sov.RunExercise();

            Television_Definition td = new Television_Definition();
            td.RunExercise();

            Basic_Array_Of_Objects baoc = new Basic_Array_Of_Objects();
            baoc.RunExercise();

            Array_Of_Possibly_Null_Objects aopno = new Array_Of_Possibly_Null_Objects();
            aopno.RunExercise();
        }
    }
    class Basic_Class_With_Instance_Method
    {
        public void RunExercise()
        {
            Toaster x = new Toaster();
            x.Print();
        }
    }
      class Toaster
    { public void Print()
        {Console.WriteLine("Hello, World, from the Instance Method Exercise!");}
    }
    
    class Instance_Variables
    {
        public void RunExercise()
        {
            Refrigerator c = new Refrigerator();
            c.getStats(3, -10, "off");
            c.Print();
            Refrigerator d = new Refrigerator();
            c.getStats(50, -30, "on");
            c.Print();
        }
    }
    class Refrigerator
    {
        private int currentTemperature;
        private int minimumTemperature;
        private string onOff;

        public void SetCurrentTemp(int newTemp)
        {
            currentTemperature = newTemp;
        }
        public void SetMinTemp(int minTemp)
        {
            minimumTemperature = minTemp;
        }
        public void OnOrOff(string eitherOr)
        {
            onOff = eitherOr;
        }
        public void getStats (int temp, int min, string isIt)
        {
            this.SetCurrentTemp(temp);
            this.SetMinTemp(min);
            this.OnOrOff(isIt);
        }
        public void Print()
        {
            Console.WriteLine("Refrigerator Object");
            Console.WriteLine("\tCurrent Temp is: {0}", currentTemperature);
            Console.WriteLine("\tMinimum Temp is: {0}", minimumTemperature);
            Console.WriteLine("\tThe Refrigerator is turned: {0}", onOff);
        }

    }

    class More_Methods
    {
        public void RunExercise()
        {
            Oven o = new Oven();
            Oven theOtherOven = new Oven();

            //// What does the ovens start out at?
            Console.WriteLine("Oven o:");
            o.Print();
            Console.WriteLine("Oven theOtherOven:");
            theOtherOven.Print();

            //// We want the over to be about 125 degrees...
            //// If it's close enough, we'll just use the current
            //// temperature.
            //// We'll check that it's close enough (+/- 5 degrees away from 125)
            if (o.GetCurrentTemp() < 120 ||
                o.GetCurrentTemp() > 130)
            {
                //    // The temperature is too far away, so
                //    // set it to be what we want, here
                o.SetCurrentTemp(125.7);
        }

        Console.WriteLine("Oven o:");
            o.Print();
            Console.WriteLine("Oven theOtherOven:");
            theOtherOven.Print();

            theOtherOven.SetCurrentTemp(200);


            Console.WriteLine("Oven o:");
            o.Print();
            Console.WriteLine("Oven theOtherOven:");
            theOtherOven.Print();
        }
    }

    class Oven
    {
        // Put your instance variables here:
        double temp;


        public void SetCurrentTemp(double temperature )
        {
            temp = temperature;
        }

        public double GetCurrentTemp()
        {

           // int tempVar = trackTemp;
            return temp;
        }

        public void Print()
        {
            Console.WriteLine(temp);
        }
    }


    class Access_Control
    {
        public void RunExercise()
        {
            Blender x = new Blender();
            Blender y = new Blender();
            x.SetSpeed(7);
            x.Print();
            y.SetSpeed(1);
            y.Print();
            x.Print(true);
            y.Print(false);
        }
    }
    class Blender
    {
        private int speed;

        public void SetSpeed(int newSpeed)
        {
            if(newSpeed<0 || 7<newSpeed)
                Console.WriteLine("WRONG!");
            if(newSpeed<=7 && 0<=newSpeed)
            speed = newSpeed;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public void Print()
        {
           
            Console.WriteLine("Blender Object:");
            Console.WriteLine("\tThe current speed is: {0} ",speed);
        }
        public void Print(bool longWinded)
        {
            if(longWinded==true)
                Console.WriteLine("For this blender, the surrent speed is: {0}", speed);
            if(longWinded==false)
                Console.WriteLine("Blender's current speed: {0}",speed);
        }
    }

    class Overloading_Create_Your_Own
    {
        public void RunExercise()
        {
        }
    }



    class Constructors_Exercise
    {
        public void RunExercise()
        {
            Dishwasher a = new Dishwasher();
            a.Print();
            Dishwasher b = new Dishwasher(0,10,1,5,3,7);
            b.Print();
        }
    }
   class Dishwasher
    {
        private int glassCurr, glassMax, plateCurr, plateMax, bowlCurr, bowlMax;
           public Dishwasher()
            {
                glassCurr = 0;
                glassMax = 10;
                plateCurr = 0;
                plateMax = 10;
                bowlCurr = 0;
                bowlMax = 10;

            }
            public Dishwasher(int gCurr, int gMax, int pCurr, int pMax, int bCurr, int bMax)
            {
                glassCurr =gCurr;
                glassMax = gMax;
                plateCurr = pCurr;
                plateMax = pMax;
                bowlCurr =bCurr;
                bowlMax = bMax;
            }
            public void Print()
            {
                Console.WriteLine("Holding\n \t{0} of {1} glasses", glassCurr, glassMax);
                Console.WriteLine("Holding\n \t{0} of {1} plates", plateCurr, plateMax);
                Console.WriteLine("Holding\n \t{0} of {1} bowls", bowlCurr, bowlMax);

            }
    }
    class Scope_Of_Variables
    {
        public void RunExercise()
        {
            NumberPrinter np = new NumberPrinter();
            np.SetLowest(3.14159);
            np.SetHighest(12);
            np.Print(true);
            np.SetHighest(17.1);
            np.Print(false);
            np.SetLowest(17); // note that lo == hi
            np.Print(false);  // no output
            np.SetLowest(22); // note that lo > hi
            np.Print(false);  // no output
        //Instance variables are variables within a class
        //Local variables are variables initialized in a method.
        //Parameters are essentially passers of a value declared as a local variable in a method.
        }
    }
    class NumberPrinter
    {
        private double lowest, highest;
        public NumberPrinter()
        {
            int low, high;
            low = 0;
            high = 0;
            lowest =low;
            highest = high;
        }
        public void SetLowest(double x)
        {
            lowest = x;
        }
 
        public void SetHighest(double y)
        {
            highest = y;
        }
        public void Print(bool checkNum)
        {
            int lower = (int)lowest-1;
            int higher = (int)lowest;

            if (checkNum == true)
            {
                while(lower <=highest)
                {
                    lower += 2;
                    if(lower<=highest)
                        Console.WriteLine(lower);
                }
            }
            if(checkNum == false)
            {
                higher++;
                for (double i = higher; higher <= highest; higher++)
                {
                    if (higher <= highest)
                    Console.WriteLine(higher);
                 
                }
              
            }

        }
    }
        
    
    public class Television_Definition
    {
        public void RunExercise()
        {
            Television ax = new Television("Sony",1000.17m,10.5);
            //ax.SetBrand("Sony");
            //string brand = ax.GetBrand();
            //ax.SetPrice(1000.17m);
            //decimal price = ax.GetPrice();
            //ax.SetSize(10.5);
            //double size = ax.GetSize();

            ax.Print();
        }
    }

    // We need a class to pass as a parameter for this exercises, so
    // we've whipped up the 'Television' class
    public class Television
    {
        private string brand;
        private decimal price;
        private double size;
        public Television()
        {
            price = 0;
            size = 0;
            brand = " ";
        }
        public Television(string br, decimal pr, double si)
        {
            if (brand != null)
                brand = br;
            else
                brand = br;
            if (0 < pr)
                price = pr;
            else
                price = 0m;
            if (0 < si)
                size = si;
            else
                size = 0.0;
        }

        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string newBrand)
        {
            if (newBrand != null)
                brand = newBrand;
            else if (newBrand == null)
                brand = newBrand;
        }
        public decimal GetPrice()
        {
            return price;
        }
        public void SetPrice(decimal newPrice)
        {
            if (0 < newPrice)
                price = newPrice;
            else
                price = 0;
        }
        public double GetSize()
        {
            return size;
        }
        public void SetSize(double newSize)
        {
            if (0 < newSize)
                size = newSize;
            else
                size = 0;
        }
        public void Print()
        {
            Console.WriteLine("Brand: {0}", brand);
            Console.WriteLine("Price: {0}", price);
            Console.WriteLine("Size: {0}", size);
        }
        public void Print(string br, decimal pr, double si)
        {
            Console.WriteLine("Brand: " + br);
            Console.WriteLine("Price: " + pr);
            Console.WriteLine("Size: " + si);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class Basic_Array_Of_Objects
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfTVs();
        }
    }

    // This is the "user interface" for the Objects-As-Parameters exercise
    public class TelevisionHandler
    {
        public void PrintArrayOfTVs()
        {
            int pr = 10;
            Television[] ts = new Television[5];
            ts[0] = new Television("Toshiba", pr , 45.5);
            ts[1] = new Television("Samsung", pr, 10.5);
            ts[2] = new Television("Sony", pr, 23.5);
            ts[3] = new Television("LG", pr, 27.5);
            ts[4] = new Television("WestingHouse", pr, 80.5);

            for (int i=0; i<ts.Length;i++)
                ts[i].Print("Brand X", pr++, 42.0);
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            Television[] tx = new Television[10];
            for(int i=0;i<tx.Length; i++)
            {
                Console.WriteLine("Slot {0} is null.", i); 
                //we get null when using a simple Television class
            }

            int totalArray = 10;
            tx[0] = new Television("Brand X", totalArray, 42.0);
            tx[1] = new Television("Brand X", totalArray, 42.0);
            tx[4] = new Television("Brand X", totalArray, 42.0);
            tx[8] = new Television("Brand X", totalArray, 42.0);
            
            for (int i = 0; i < tx.Length; i++)
            {
                if(tx[i]==null)
                Console.WriteLine("Slot {0} is null.", i); 
                if(tx[i]!=null)
                   tx[i].Print("Brand X",i+totalArray,42.0);
            // when we get a null value we print out which values are null 
            // but print the defined televisions
            }
            for (int i = 0; i < tx.Length; i++)
            {
                if (tx[i] == null)
                    tx[i] = new Television("Brand X", 10 + i, 42.0);
                if (tx[i] != null)
                    tx[i].Print("Brand X", 10 + i, 42.0);
               //once we find a null value in the array
               //we create a new television and give it some values
               //then we print.
            }
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    class Array_Of_Possibly_Null_Objects 
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfPossiblyNullTVs();
        }
    }
}