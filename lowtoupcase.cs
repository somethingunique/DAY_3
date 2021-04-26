using System;  
  
public class Program  
{  
    public static void Main()  
    {  
        char result;  
        string name;
        Console.WriteLine("Enter a String");
        name = Console.ReadLine();  
        char[] charArry = name.ToCharArray();  
        foreach (var data in charArry)  
        {  
            if (Char.IsLower(data))  
            {  
                result = Char.ToUpper(data);  
            }  
            else  
            {  
                result = Char.ToLower(data);  
            }  
  
            Console.Write(result);  
        }  
    }  
}