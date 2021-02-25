using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hahahfunny : MonoBehaviour
{
    public void startGame() {
        SceneManager.LoadScene(14);
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void Credits() {
        Debug.Log("El No Sabe PepeLaugh");
    }
}
