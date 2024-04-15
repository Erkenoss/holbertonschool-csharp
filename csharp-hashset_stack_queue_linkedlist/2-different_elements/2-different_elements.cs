using System;
using System.Collections.Generic;

class List {
    public static List<int> DifferentElements(List<int> list1, List<int> list2) {

        if (list1 != null && list2 != null) {
            List<int> myList = new List<int>(list1);

            foreach (int nbr in list2) {
                if (myList.Contains(nbr)) {
                    myList.Remove(nbr);
                }
                else {
                    myList.Add(nbr);
                }
            }
            myList.Sort();
            return myList;
        }
       return null;
    }

}
