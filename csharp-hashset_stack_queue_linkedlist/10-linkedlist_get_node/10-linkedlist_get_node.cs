using System;
using System.Collections.Generic;

class LList {
    public static int GetNode(LinkedList<int> myLList, int n) {
        if (n >= 0 && n < myLList.Count){
            return myLList.ElementAt(n);
        }
        return 0;
    }
}