using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwapper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(Transist());
    }

    
    IEnumerator Transist() {
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(5);
    }
}
