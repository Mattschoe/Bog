using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gregd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TilMm());
    }
    IEnumerator TilMm() {
        yield return new WaitForSecondsRealtime(16);
        SceneManager.LoadScene(0);
    }
}
