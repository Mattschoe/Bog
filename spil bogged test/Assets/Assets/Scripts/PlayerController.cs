using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerController : MonoBehaviour
{
    public float Hastighed;
    public Rigidbody Rb;
    void Start ()
    {
        Hastighed = 5f;
    }
    void FixedUpdate()
    {
        Rb.drag = Rb.velocity.magnitude;
        if (Rb.drag <= 1) {
            Rb.drag = 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rb.AddRelativeForce(0, 0, Hastighed * 5);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rb.AddRelativeForce(0, 0, -Hastighed * 5);
        }
    }
}
