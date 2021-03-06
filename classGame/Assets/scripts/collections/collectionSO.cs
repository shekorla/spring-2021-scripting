using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using UnityEngine;
[CreateAssetMenu]
public class collectionSO : ScriptableObject
{
    public List<collectableSO> inventory;
    public float bank;

    public void Awake()
    {
        empty();
        bank = 0f;
    }

    public void pickedUp(collectableSO prize)
    {
        inventory.Add(prize);
        prize.collected = true;
    }

    public void lostIt(collectableSO obj)
    {
        foreach (var item in inventory.Where(item=>item==obj))
        {
            item.collected = false;
            inventory.Remove(item);
        }
    }

    public void empty()
    {
        foreach (var item in inventory)
        {
            item.collected = false;
        }
        inventory.Clear();
    }

    public void profit(moneySO prize)
    {
        bank +=prize.worth;
    }
}
