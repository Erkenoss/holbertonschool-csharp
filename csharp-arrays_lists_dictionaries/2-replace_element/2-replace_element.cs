using System;

class Array {
    public static int[] ReplaceElement(int[] array, int index, int n) {
        if (array != null && index > 0 && index < array.Length) {
            int[] newArray = array;
            newArray[index] = n;
            return newArray;
        }
        else {
            Console.WriteLine("Index out of range");
            return array;
        }
    }
}