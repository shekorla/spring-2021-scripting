using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class paddle : MonoBehaviour
{
    float mousePos;
    double offset=3;
    private Vector3 paddlePos;
    public static bool simulateMouseWithTouches = true;
    //bool upgrade = false;
    void Update()
    {
        mousePos = Input.mousePosition.x / Screen.width * 16;
        paddlePos = new Vector3((float) (mousePos-offset), this.transform.position.y, 0f);
        this.transform.position = paddlePos;
    }

    void OnTriggerEnter2D(Collider2D Collision)
    {
        //if (Collision.gameObject.CompareTag("powerup"))
        {
            this.transform.localScale = new Vector3(5,1,1);
            //upgrade = true;
        }

    }
    
}
