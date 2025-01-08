using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    [SerializeField]
    private float jumpSpeed = 10f;

    [SerializeField]
    private Collider2D groundSensor = null;

    [SerializeField]
    private LayerMask groundLayer = 0;

    // Reference variable so we can use the Rigidbody
    // Set it to null by default, which means we do not have a reference yet.
    private Rigidbody2D physicsBody = null;

    // Awake is called before start
    private void Awake()
    {
        physicsBody = GetComponent<Rigidbody2D>();
    }


    public void Jump()
    {

        if (groundSensor.IsTouchingLayers(groundLayer))
        {
            //Make a variable to hold our velocity and get the current velocity from the physics component
            Vector2 newVelocity = physicsBody.velocity;

            // Set our velocity to move in the negative x (upwards) direction
            newVelocity.y = speed;

            //Update our physics components velocity to be our newly changed value
            physicsBody.velocity = newVelocity;
        }

        
    }


    public void MoveLeft()
    {
        //Make a variable to hold our velocity and get the current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;

        // Set our velocity to move in the negative x (left) direction
        newVelocity.x = -speed;

        //Update our physics components velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    public void MoveRight()
    {
        //Make a variable to hold our velocity and get the current velocity from the physics component
        Vector2 newVelocity = physicsBody.velocity;

        // Set our velocity to move in the negative x (right) direction
        newVelocity.x = speed;

        //Update our physics components velocity to be our newly changed value
        physicsBody.velocity = newVelocity;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
