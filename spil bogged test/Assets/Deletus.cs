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
        StartCoroutine(TilR�dRum());
    }
    IEnumerator TilR�dRum() {
        yield return new WaitForSecondsRealtime(5);
        SceneManager.LoadScene(12);
    }
}
