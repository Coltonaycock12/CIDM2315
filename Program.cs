namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        // Q1:
        int num1 = Convert.ToInt16(Console.ReadLine());
        int num2 =  Convert.ToInt16(Console.ReadLine());
        int max = Largest(num1, num2);
        Console.WriteLine($"a = {num1}; b={num2}");
        Console.WriteLine($"The largest number is: {max}");
        Triangle(5,"right");
    }
    
        static int Largest(int a, int b){
            // find the largest number and return it
            if(a > b){
                return a;
            }
            else{
                return b;
            }
        }

        //Q2:
        static void Triangle(int N, string shape){
            Console.WriteLine($"N is {N}; shape is {shape}");

            if(shape == "left"){
                // nested for loop to print left Triangle
                for(int row = 0; row<N; row++){
                    for(int col = 0; col<5; col++)
                    {
                        if(row>=col)
                        Console.Write('*');   
                    }
                    Console.WriteLine("");
                }
            }
        
          
            if(shape == "right"){
                // nested for loop to print right Triangle
                int i, j, k ;  
                for (i = 1; i <= N; i++)  
                {  
                    for (j = 1; j <= N-i; j++)  
                    {  
                    Console.Write(" ");  
                    }  
                    for (k = 1; k <= i; k++)  
                    {  
                    Console.Write("*");  
                    }  
                    Console.WriteLine("");  
                }  
                Console.ReadLine();   
            }
    }
        
}



