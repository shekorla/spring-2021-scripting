using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class playerBeh : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 position;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = speed * Input.GetAxis("Horizontal");
        position.z = speed * Input.GetAxis("Vertical");
        controller.Move(position * Time.deltaTime);
    }
}
