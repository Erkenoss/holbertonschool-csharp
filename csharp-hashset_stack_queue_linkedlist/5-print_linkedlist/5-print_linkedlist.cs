using System;
using System.Collections.Generic;

class LList {
    public static LinkedList<int> CreatePrint(int size) {
        LinkedList<int> llist = new LinkedList<int>();

        if (size < 0) {
            return new LinkedList<int>();
        }
        else {
            for (int i = 0; i < size; i++) {
                llist.AddLast(i);
                Console.WriteLine("{0}", i);
            }
            return llist;
        }

    }
}