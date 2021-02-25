using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class skiftscenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator Skift() {
        yield return new WaitForSecondsRealtime(6);
        SceneManager.LoadScene(3);
    }
}
