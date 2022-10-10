using System;
class GFG
{
    static int ASCII_SIZE = 256;
    static char getMaxOccurringChar(String str)
    {
     
        int[] count = new int[ASCII_SIZE];
      
        int len = str.Length;
        for (int i = 0; i < len; i++)
            count[str[i]]++;
        int max = -1; 
        char result = ' '; 
        for (int i = 0; i < len; i++)
        {
            if (max < count[str[i]])
            {
                max = count[str[i]];
                result = str[i];
            }
            
        }
        for (int i = 0;i < len; i++)
        {
            if (max == count[str[i]])
            {
                return result;
            }
        }
        return result;

    }
    
    public static void Main()
    {
        string str = "A text or texting";
        
        Console.Write("Max occurring character is "
                      + getMaxOccurringChar(str));
    }
}