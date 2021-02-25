using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GotoScene2());
    }
    IEnumerator GotoScene2()
    {
        yield return new WaitForSecondsRealtime(6.5f);
        SceneManager.LoadScene(2);
    }
}
