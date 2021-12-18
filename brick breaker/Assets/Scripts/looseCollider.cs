using System;
using UnityEngine;
using System.Collections;

public class looseCollider : MonoBehaviour {

    public LevelManager LM;

    private void Start()
    {
        LM = GameObject.FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D Collision) {
        if (Collision.gameObject.CompareTag("Player"))
        {
            LM.LoadLevel("lose screen");
        }
    }
}
