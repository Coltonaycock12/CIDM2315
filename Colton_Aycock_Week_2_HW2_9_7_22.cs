namespace Week2Practice;
class Program
{
    static void Main(string[] args)
    {
        //Q1
        //switch statement
        Console.WriteLine("Please input a letter grade:  ");
        string letterGrade = Console.ReadLine();
        switch (letterGrade)
        {
        case "A": 
            Console.WriteLine("GPA point: 4");
            break;
        case "B": 
            Console.WriteLine("GPA point: 3");
            break;
        case "C": 
            Console.WriteLine("GPA point: 2");
            break; 
        case "D":
            Console.WriteLine("GPA point: 1");
            break; 
        case "F":
            Console.WriteLine("GPA point: 0");
            break; 
        
        default: 
            Console.WriteLine("Wrong Letter Grade!"); 
            break; 
        }

        //Q2
        //nested if statement 
        Console.WriteLine("Please input three numbers: ");
        string str_n1 = Console.ReadLine();
        int n1 = Convert.ToInt16(str_n1);
        string str_n2 = Console.ReadLine();
        int n2 = Convert.ToInt16(str_n2);
        string str_n3 = Console.ReadLine(); 
        int n3 = Convert.ToInt16(str_n3);
        if(n1<n2){
            if(n1<n3){ //n1<n2 and n1<n3
                Console.WriteLine($"The smallest value is: {n1}");
            }
            else{//n1<=n2 and n3<=n1
                Console.WriteLine($"The smallest value is: {n3}"); 
            }
        } 
        else{// n2<=n1
            if(n2<n3){
                Console.WriteLine($"The smallest value is: {n2}");
            }
            else{//n3<=n2
                Console.WriteLine($"The smallest value is: {n3}");

            
            }
        }

        //Q3 Bonus
        //Logical operators   
        Console.WriteLine("Please input a year : ");
        int Year = int.Parse(Console.ReadLine()); 
        if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) Console.WriteLine("{0} is a Leap Year.", Year);
        else Console.WriteLine("{0} is not a Leap Year.", Year);
        Console.ReadLine();
    }
}
   





