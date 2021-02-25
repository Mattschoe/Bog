using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroide : MonoBehaviour
{
    public GameObject SpaceShip;
    public GameObject Asteroide;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAsteroider());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = SpaceShip.transform.position + new Vector3(Random.Range(-5, 5), 50, 0);
    }
    IEnumerator SpawnAsteroider()
    {
        yield return new WaitForSecondsRealtime(0.7f);
        Instantiate(Asteroide, new Vector3(transform.position.x,transform.position.y,12f), transform.rotation);
        StartCoroutine(SpawnAsteroider());
    }
}
