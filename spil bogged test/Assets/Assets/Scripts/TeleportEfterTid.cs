using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportEfterTid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TilMm());
    }
    IEnumerator TilMm()
    {
        yield return new WaitForSecondsRealtime(15);
        SceneManager.LoadScene(21);
    }
}

