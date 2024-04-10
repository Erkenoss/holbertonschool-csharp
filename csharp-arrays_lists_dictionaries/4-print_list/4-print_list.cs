using System;
using System.Collections.Generic;

class List {
    public static List<int> CreatePrint(int size) {
        if (size < 0) {
            Console.Write("Size cannot be negative\n");
            return null;
        }

        if (size == 0) {
            Console.WriteLine();
            return new List<int>();
        }
        List<int> newList = new List<int>();
        for (int i = 0; i < size; i++) {
            newList.Add(i);
            if (i < size - 1) {
                Console.Write(newList[i] + " ");
            }
            else {
                Console.Write(newList[i] + "\n");
            }
        }
        return newList;
    }
}