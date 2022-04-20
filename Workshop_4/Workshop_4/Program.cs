using System;

namespace Workshop_4;

class Program
{
    public void HarmonicNumber()
    {
        Console.WriteLine("Enter Number");
        int Num= int .Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= Num; i++)
        {
            
            sum = sum + 1 / (float)i;
            
        }
        Console.WriteLine("Harmonic value is : " + sum);
    }

    public static void Main(String[] args)
    {
       Program harmonic= new Program();
        harmonic.HarmonicNumber();
    }
}


//Harmonic Number
//a. Desc ­> Prints the Nth harmonic number: 1 / 1 + 1 / 2 + ... +1 / N
//    (http://users.encs.concordia.ca/~chvatal/notes/harmonic.html).
//    b.I / P ­> The Harmonic Value N.Ensure N != 0
//    c.Logic ­> compute 1 / 1 + 1 / 2 + 1 / 3 + ... +1 / N
//    d.O / P ­> Print the Nth Harmonic Value.



