using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnStjerne : MonoBehaviour
{
    public float points; 
    public GameObject Stjerne;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        StartCoroutine(SpawnStjerner());
    }

    // Update is called once per frame
    void Update()
    {
        points += Time.deltaTime;
        transform.position = new Vector3(Random.Range(-50,50),100,0);
        if (points >= 30) {

        }
    }
    IEnumerator SpawnStjerner()
    {
        yield return new WaitForSecondsRealtime(0.2f);
        Instantiate(Stjerne,transform.position,transform.rotation); 
        StartCoroutine(SpawnStjerner());
    }

}
