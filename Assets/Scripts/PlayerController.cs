using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Speed and turn speed of the vehicle
    public float speed = 5.0f; // Speed of the vehicle
    public float turnSpeed;
    // Input action for movement
    public InputAction moveAction;
    // Input value for movement
    private Vector2 moveInput;

    private void Start()
    {
        // Enable the move action
        moveAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // Read the input value from the move action
        moveInput = moveAction.ReadValue<Vector2>();
        //Move the Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
