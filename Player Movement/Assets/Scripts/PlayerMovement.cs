using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float MoveSpeed;

    public Transform PlayerOrientation;

    float HoriInput;
    float VertInput;

    Vector3 moveDirection;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        
    }
    void Update()
    {
        Inputs();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void Inputs()
    {
        HoriInput = Input.GetAxisRaw("Horizontal");
        VertInput = Input.GetAxisRaw("Vertical");

    }
    
    private void MovePlayer()
    {
        //Calculates the direction in which to move the charachter
        moveDirection = PlayerOrientation.forward * VertInput + PlayerOrientation.right * HoriInput;
        rb.AddForce (moveDirection.normalized * MoveSpeed * 10f, ForceMode.Force);
    }
   
}
