﻿using System;

class Array {
    public static int[] ReplaceElement(int[] array, int index, int n) {
        if (index == 0 && array != null) {
            array[index] = n;
            return array;
        }
        if (array != null && index < array.Length) {
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