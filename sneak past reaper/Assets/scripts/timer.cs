using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class timer : MonoBehaviour
{
    public UnityEvent timeUp;

    public void waitPlease(int howLong)
    {
        StartCoroutine(Waiting(howLong));
    }

    IEnumerator Waiting(int howLong)
    {
        yield return new WaitForSecondsRealtime(howLong);
        timeUp.Invoke();
    }
}
