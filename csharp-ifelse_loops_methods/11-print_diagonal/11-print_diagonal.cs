using System;

class Line {
    public static void PrintDiagonal(int length) {
        if (length <= 0) {
            Console.WriteLine();
            return;
        }

        int space = 0;
        int backSlash = 0;
        while (space < length) {
            while (backSlash < space) {
                Console.Write(' ');
                backSlash++;
            }
            Console.Write("\\\n");
            space++;
            backSlash = 0;
        }
    }
}