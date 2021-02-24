using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Asteroid")
        {
            StartCoroutine(UShitMate());
            Time.timeScale = 0.5f; 
        }
    }
    IEnumerator UShitMate() {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(3);
    }
}
