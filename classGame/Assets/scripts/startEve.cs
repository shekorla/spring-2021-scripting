using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class startEve : MonoBehaviour
{
    public UnityEvent startEv, destEv;
    private void Start()
    {
        startEv.Invoke();
    }

    private void OnDestroy()
    {
        destEv.Invoke();
    }
}
