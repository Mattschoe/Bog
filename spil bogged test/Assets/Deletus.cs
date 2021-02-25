using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deletus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(TilRødRum());
    }
    IEnumerator TilRødRum() {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene(12);
    }
}
