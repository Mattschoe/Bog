using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stjerne : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = Random.Range(15, 25);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -Speed*Time.deltaTime, 0);
        if (transform.position.y <= -10) {
            Destroy(gameObject);
        }
    }
}
