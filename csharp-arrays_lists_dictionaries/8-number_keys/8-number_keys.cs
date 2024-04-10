using System;
using System.Collections.Generic;

class Dictionary {
    public static int NumberOfKeys(Dictionary<string, string> myDict) {
        if (myDict != null) {
            int keyCount = 0;
            foreach (var pair in myDict) {
                keyCount++;
            }
            return keyCount;
        }
        else {
            return 0;
        }
    }
}