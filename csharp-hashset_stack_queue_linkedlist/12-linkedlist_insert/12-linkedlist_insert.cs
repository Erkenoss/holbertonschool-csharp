using System;
using System.Collections.Generic;

class LList {
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n) {
        LinkedListNode<int> tempNode = myLList.First;

        if (tempNode != null) {
            if (n < tempNode.Value) {
                myLList.AddBefore(tempNode, n);
                return myLList;
            }

            tempNode = tempNode.next;
        }
        return myLList.AddLast(n);
    }
}