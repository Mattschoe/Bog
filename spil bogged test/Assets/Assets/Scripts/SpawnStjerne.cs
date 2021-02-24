using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStjerne : MonoBehaviour
{
    public GameObject Stjerne;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnStjerner());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Random.Range(-50,50),100,0);
    }
    IEnumerator SpawnStjerner()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Instantiate(Stjerne,transform.position,transform.rotation); 
        StartCoroutine(SpawnStjerner());
    }

}
