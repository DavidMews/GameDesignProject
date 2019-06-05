using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public bool isMoving = false;
    public Vector3 inputVector;
    [SerializeField] private float movementSpeed;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
            if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isMoving == false)
            {
                isMoving = true;       
                inputVector = new Vector3(movementSpeed, 0, 0);              
            }
             if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && isMoving == false)
            {
                isMoving = true;
                inputVector = new Vector3(movementSpeed*-1, 0, 0);
 
            }
             if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && isMoving == false)
            {
                isMoving = true;
                inputVector = new Vector3(0, 0, movementSpeed);      
            }
             if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && isMoving == false)
            {
               isMoving = true;
               inputVector = new Vector3(0, 0, movementSpeed *-1);
            }
    }
    void FixedUpdate()
    {

        print(rb.velocity);
        rb.velocity = inputVector ;
    }
}
