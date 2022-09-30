namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        //Q1
        int integer1 = getInteger();
        int integer2 = getInteger();
        int max = Largest(integer1, integer2);
        Console.WriteLine($"a = {integer1}; b={integer2}");
        Console.WriteLine($"The largest number is: {max}");

        int integer3 = getInteger();
        int integer4 = getInteger();
        int max2 = LargestFour(integer1, integer2, integer3, integer4);
        Console.WriteLine($"a = {integer1}; b = {integer2}; c = {integer3}; d = {integer4}");
        Console.WriteLine($"The largest number is: {max2}"); 
        createAccount(); 
    }

    static int getInteger(){
        string str_input = Console.ReadLine();
        int int_input = Convert.ToInt16(str_input);
        return int_input;    
    }
    
    // Q2 Largest
    static int Largest(int a, int b){
        if(a>b){
            return a;
        }else{
            return b;
        }
    }
    static int LargestFour(int a, int b, int c, int d){
        int max1 = Largest(a,b);
        int max2 = Largest(c,d);
        int max = Largest(max1,max2);
        return max; 
    }

        //Q3
        static bool checkAge(int birth_year)
        {
            int age = 2022 - birth_year;
            if(age>=18) return true; 
            else return false;
        }
 
        static void createAccount()
        {
            Console.WriteLine("Enter Username:");
            string user = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string pass = Console.ReadLine();
            Console.WriteLine("Re-Enter Password:");
            string passw = Console.ReadLine();
            Console.WriteLine("Enter Birth Year:");
            int byr = Convert.ToInt32(Console.ReadLine());
            if ((checkAge(byr) == true) && (pass == passw))
            {
                Console.WriteLine("Account is created successfully");
            }
            else if (pass != passw)
            {
                Console.WriteLine("Wrong password");
            }
            else Console.WriteLine("Could not create account"); 
        }
    }
        
        
