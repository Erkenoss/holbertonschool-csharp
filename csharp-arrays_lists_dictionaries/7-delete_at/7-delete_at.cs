using System;
using System.Collections.Generic;

class List {
    public static List<int> DeleteAt(List<int> myList, int index) {
        if (myList != null && index + 1 < myList.Count && index >= 0) {
            myList.Remove(index + 1);
        }
        return myList;
    }
}