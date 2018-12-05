using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helpers  {

    public static GameObject RemoveElementFromArray(GameObject[] gos, int index)
    {

        if ((index < 0 )||(index >= gos.Length))
        {
            return null;
        }

        if (gos[index] == null)
        {
            return  null;
        }

        GameObject objectToDelete = gos[index];

        for (int i = index; i < (gos.Length - 1); i++)
        {
            gos[i] = gos[i + 1]; // pop array
        }
        gos[gos.Length - 1] = null; // remove last element from array since we're left with a duplicate

        return objectToDelete;
    }

    public static GameObject AddElementToArray(GameObject[] gos, int index, GameObject newElement)
    {
        if ((index < 0)||(index >= gos.Length)) //gos = hand, index = availablehandslot, new element = deck[passedindex]
        {
            return null;
        }

        GameObject oldElement = gos[index];
        gos[index] = newElement;


        return oldElement;


    }

}
