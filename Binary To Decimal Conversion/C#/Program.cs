using System;

// C# program to convert
//binary to decimal

//Function to convert
//binary to decimal

class GFG
{
    public static int binaryToDecimal(int n)
    {
        int num = n;
        int dec_value = 0;

        //initializing base1
        //value to 1, i.e 2^0
        int base1 = 1;

        int temp = num;
        while (temp > 0) {
            int last_digit = temp % 10;
            temp = temp / 10;

            dec_value += last_digit * base1;

            base1 = base1 * 2;
        }

        return dec_value;
    }

    static bool isbin(string s)
        {
            foreach (var c in s)
                if (c != '0' && c != '1')
                return false;
            return true;
        }
// Driver code
    public static void Main()
        {
        Console.WriteLine("Enter a binary number:");
        int num = Convert.ToInt32(Console.ReadLine());

        System.Console.Write(binaryToDecimal(num));
        }   

}