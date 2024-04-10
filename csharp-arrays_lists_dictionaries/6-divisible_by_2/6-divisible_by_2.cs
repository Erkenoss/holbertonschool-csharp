using System;
using System.Collections.Generic;

class List {
    public static List<bool> DivisibleBy2(List<int> myList) {
        if (myList != null) {
            List<bool> newList = new List<bool>(myList.Count);
            foreach (int element in myList) {
                if (element % 2 == 0) {
                    newList.Add(true);
                }
                else {
                    newList.Add(false);
                }
            }
            return newList;
        }
        return new List<bool>();
    }
}