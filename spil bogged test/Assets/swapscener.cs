using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class swapscener : MonoBehaviour
{
    // Start is called before the first frame update

    public void Ja()
    {
        SceneManager.LoadScene(10);
    }
    public void Nej()
    {
        SceneManager.LoadScene(9); 
    }
}
