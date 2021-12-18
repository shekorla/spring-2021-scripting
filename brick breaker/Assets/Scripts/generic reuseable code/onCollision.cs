using UnityEngine;
using UnityEngine.Events;

public class onCollision : MonoBehaviour
{
    public UnityEvent collideEvent, collidePlrEvent;
    void OnTriggerEnter2D(Collider2D Collision) {
        if (Collision.gameObject.CompareTag("Player"))
        {
            collidePlrEvent.Invoke();
        }
        else
        {
            collideEvent.Invoke();
        }
    }
}
