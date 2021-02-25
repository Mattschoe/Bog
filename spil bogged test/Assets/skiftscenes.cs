using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skiftscenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Skift());
    }
    IEnumerator Skift() {
        yield return new WaitForSecondsRealtime(10);
        SceneManager.LoadScene(8);
    }
}
