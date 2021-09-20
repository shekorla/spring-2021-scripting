using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class playerBeh : MonoBehaviour
{
    public float speed = 1f, sound=5f;// sound is amt of noise player makes
    private float tempSpeed, tempSound;
    private Vector3 position;
    private CharacterController controller;
    public UnityEvent sneakEv, runEv;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        tempSpeed = speed;
        tempSound = sound;
    }
//slow down speed for sneaking
    public void swapSneak()
    {
        if (tempSpeed != speed * .5f)
        {
            tempSpeed = speed * .5f;
            tempSound = sound * .4f;
        }
        else
        {
            tempSpeed = speed;
            tempSound = sound;
        }
        sneakEv.Invoke();
        Debug.Log(tempSpeed);
    } 
//speed up for running
    public void swapRun()
    {
        if (tempSpeed != speed * 2f)
        {
            tempSpeed = speed * 2f;
            tempSound = sound*1.6f;
        }
        else
        {
            tempSpeed = speed;
            tempSound = sound;
        }
        runEv.Invoke();
        Debug.Log(tempSpeed);
    }

    public void noisey(GameObject volume)
    {
        volume.transform.localScale = new Vector3(tempSound, tempSound, tempSound);
    }
    void Update()
    {
        position.x = tempSpeed * Input.GetAxis("Horizontal");
        position.z = tempSpeed * Input.GetAxis("Vertical");
        controller.Move(position * Time.deltaTime);
    }

}
