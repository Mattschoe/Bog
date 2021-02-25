using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class YEP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Change());
    }
    IEnumerator Change() {
        yield return new WaitForSecondsRealtime(10);
        SceneManager.LoadScene(5);
    }
}
