using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class paddle : MonoBehaviour
{
    float mousePos;
    double offset=3;
    //bool upgrade = false;

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition.x / Screen.width * 16;
        Vector3 paddlePos = new Vector3((float) (mousePos-offset), this.transform.position.y, 0f);

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
