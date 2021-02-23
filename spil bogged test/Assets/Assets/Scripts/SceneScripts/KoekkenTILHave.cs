using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KoekkenTILHave : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tissemand")
        {
            SceneManager.LoadScene(0);
        }

        if (other.tag == "TissemandTILVaerelse")
        {
            SceneManager.LoadScene(4);
        }

        if (other.tag == "Tissemand")
        {
            SceneManager.LoadScene(2);
        }

        if (other.tag == "Tissemand")
        {
            SceneManager.LoadScene(3);
        }
    }
}
