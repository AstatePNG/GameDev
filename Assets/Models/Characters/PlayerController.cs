using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 6.0f;
    private Vector3 movement = Vector3.zero;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if(rb == null) Debug.LogWarning("j'ai pas trouvé le rigid body l + ratio");
    }

    // Update is called once per frame
    void Update()
    {
        movement = Vector3.zero;
        if (Keyboard.current.downArrowKey.isPressed) movement += Vector3.back;
        if (Keyboard.current.upArrowKey.isPressed) movement += Vector3.forward;
        if (Keyboard.current.leftArrowKey.isPressed) movement += Vector3.left;
        if (Keyboard.current.rightArrowKey.isPressed) movement += Vector3.right;
	
        Vector3 velocity = movement.normalized * moveSpeed;
        rb.linearVelocity = velocity;
    }
}
