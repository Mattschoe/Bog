using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerController : MonoBehaviour
{
    public float Hastighed;

    void Start ()
    {
        Hastighed = 5f;
    }
    void Update()
    {
        transform.Translate(0f, 0f, -Input.GetAxis("Horizontal") * Time.deltaTime*Hastighed);
    }
}
