using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trigEveBeha : MonoBehaviour
{
    public UnityEvent trigEntEv;
    private void OnTriggerEnter(Collider other)
    {
       trigEntEv.Invoke(); 
    }
}
