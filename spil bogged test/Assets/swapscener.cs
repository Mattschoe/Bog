using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class swapscener : MonoBehaviour
{
    // Start is called before the first frame update

    public void Ja()
    {
        SceneManager.LoadScene(9);
    }
    public void Nej()
    {
        SceneManager.LoadScene(8); 
    }

    //Hvis vi ønsker at have flere forskellig farvet rakketter så skal vi ændre
    //en af dem her til at loade en anden scene ind
    public void Red()
    {
        SceneManager.LoadScene(4);
    }
    public void Blue()
    {
        SceneManager.LoadScene(4);
    }

    //Main Menu
    public void Start()
    {
        SceneManager.LoadScene(1);
    }
    public void Credits()
    {
        SceneManager.LoadScene(13);
    }
}
