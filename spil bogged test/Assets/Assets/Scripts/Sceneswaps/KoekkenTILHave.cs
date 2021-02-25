using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KoekkenTILHave : MonoBehaviour
{
    public Text tekst;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tissemand")
        {
            SceneManager.LoadScene(3);
        }

        if (other.tag == "TissemandTILVaerelse")
        {
            SceneManager.LoadScene(2);
        }

        if (other.tag == "TissemandTILKoekken")
        {
            SceneManager.LoadScene(6);
        }

        if (other.tag == "VaerelseTILKoekken")
        {
            SceneManager.LoadScene(6);
        }

        if (other.tag == "TissemandTILVaelgRumskib")
        {
            SceneManager.LoadScene(20);
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Get food")
        {
            tekst.enabled = true;
        }
        else {
            tekst.enabled = false;
        }
        if (other.tag == "Get food" && Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(TilCutscene());
            Debug.Log("Yeet");
        }
    }
    IEnumerator TilCutscene() {
        yield return new WaitForSecondsRealtime(2.5f);
        SceneManager.LoadScene(7);
    }
}
