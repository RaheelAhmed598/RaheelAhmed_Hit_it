using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoRotation : MonoBehaviour
{
    public float speed;

    //physic component 
    public Rigidbody2D rb;

    //use for moving UFO rotation like wheel
    public WheelJoint2D wheeljoint;

    private void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    //wheel joint is used with motorjoined for
    //Parameters for the optional motor force applied to a Joint2D
    //using properties like maxmotortorque and motorspeed
    //just like used in the car's wheel of climbing hill game
    private void FixedUpdate()
    {
        wheeljoint.useMotor = true;
        JointMotor2D motor = new JointMotor2D { maxMotorTorque = wheeljoint.motor.maxMotorTorque, motorSpeed = speed };
        wheeljoint.motor = motor;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // checking collision condition 
        if (collision.gameObject.tag == "Missile")
        {
            //add score atfer collision with +2
            ScoreText.score += 2; 

            //Tag  of the missile that stuck with ufo after hitting
            collision.gameObject.tag = "Missilestuck";

            //Changing the parent will modify the parent - relative position, scale and rotation 
            //keep the world space position, rotation and scale of the UFO.
              Destroy(collision.attachedRigidbody);
            collision.transform.parent = this.transform;

        }
    }

}
