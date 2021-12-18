using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ArtArraySO : ScriptableObject
{
    public ArrayList myList;

    public void newArt(Sprite item)
    {
        myList.Add(item);
    }

    public void unlockedCheck()
    {
        foreach (Sprite item in myList)
        {
            //list every item in list aka each item you have already purchased
        }
    }
}
