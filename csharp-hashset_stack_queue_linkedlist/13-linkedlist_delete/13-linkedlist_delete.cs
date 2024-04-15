using System;
using System.Collections.Generic;

class LList {
    public static void Delete(LinkedList<int> myLList, int index) {
        LinkedListNode<int> tempNode = myLList.First;

        if (index <= myLList.Count && index >= 0) {
            for (int i = 0; i < index; i++) {
                tempNode = tempNode.Next;
            }
            myLList.Remove(tempNode);
        }

    }
}