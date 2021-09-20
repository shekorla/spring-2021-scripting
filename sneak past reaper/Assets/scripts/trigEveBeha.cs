using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trigEveBeha : MonoBehaviour
{
    public UnityEvent trigEntEv,plrTrigEv,wallTrigEv;
    private void OnTriggerEnter(Collider other)
    {
       trigEntEv.Invoke(); //triggers when anything enters
       if (other.CompareTag("Player"))
       {
           plrTrigEv.Invoke();//triggers only when hit player
       }
       else if (other.CompareTag("Wall"))
       {
           wallTrigEv.Invoke();//when a wall comes between 
       }
       
    }
}
