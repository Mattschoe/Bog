using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollBlue : MonoBehaviour
{
    public AudioSource Boom;
    public Text Deth;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Asteroid")
        {
            StartCoroutine(UShitMate());
            Time.timeScale = 0.5f;
            Deth.enabled = true;
            if (Boom.isPlaying == false)
            {
                Boom.Play();
            }
        }
    }
    IEnumerator UShitMate()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(4);
    }
}
