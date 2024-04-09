using System;

class Program
{
    static void Main(string[] args)
    {
        int i;
        for (i = 0; i <= 99; i++) {
            if (i/10 != i%10 && i%10 > i/10) {
                if (i != 89) {
                    Console.Write("{0}{1}, ", i/10, i%10);
                }
                else {
                    Console.Write("{0}\n", i);
                }
            }
        }
    }
}
