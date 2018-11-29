using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers  {

    public static void RemoveElementFromArray(GameObject[] gos, int index)
    {

        if ((index < 0 )||(index >= gos.Length))
        {
            return;
        }

        if (gos[index] == null)
        {
            return;
        }

        for (int i = index; i < (gos.Length - 1); i++)
        {
            gos[i] = gos[i + 1]; // pop array
        }
        gos[gos.Length - 1] = null; // remove last element from array since we're left with a duplicate
    }
}
