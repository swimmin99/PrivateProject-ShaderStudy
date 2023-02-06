using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.001f;
    public float movement;
    public float rotation;
    Rigidbody RB;
    private void Start()
    {
        RB = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        moveCharacter(movement, rotation);
        print(movement);
    }
    void moveCharacter(float movement, float rotation)
    {
        RB.AddRelativeForce(new Vector3(0, 0, -movement).normalized * speed);
        // RB.velocity = direction * speed;
      RB.AddTorque(new Vector3(0, rotation, 0).normalized * (speed/10));


    }

}
