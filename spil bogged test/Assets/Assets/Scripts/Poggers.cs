using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Poggers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(TilBl�Rum());
    }
    IEnumerator TilBl�Rum()
    {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene(19);
    }
}
