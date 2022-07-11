using System;


namespace Sweeft_Digital_3
{
    internal class Program
    {
        public static int MyArrayMinValue(int[] array)
        {
            int minvalue = 1;
            for (int i = 1; i <= int.MaxValue; i++)
            {
                bool found = false;
                
                foreach (var item in array)
                {
                    if (i == item) {
                        found = true;
                        break;                  
                    }                  
                }

                if (!found)
                {
                    minvalue = i;
                    break;
                }               
            }      
           
            return minvalue;
        }
        static void Main(string[] args)
        {
            int[] MyArray = { 1, 2, 3, 5, 13 };
            int resultMinValue = MyArrayMinValue(MyArray);
            Console.WriteLine($"MinValue : {resultMinValue}");
        }
    }
}

