using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class swapscener : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public void Nej()
    {
        SceneManager.LoadScene(8);
    }
    public void Ja()
    {
        SceneManager.LoadScene(9);
    }
}
