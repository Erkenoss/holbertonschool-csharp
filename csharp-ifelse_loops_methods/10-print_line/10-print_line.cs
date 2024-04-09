using System;

class Line {
    public static void PrintLine(int lenght) {
        if (lenght <= 0) {
            Console.WriteLine();
            return;
        }
        for (int i = 0; i < lenght; i++) {
            Console.Write('_');
        }
        Console.WriteLine();
    }
}