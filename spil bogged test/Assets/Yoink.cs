using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yoink : MonoBehaviour
{
    public void Blue() {
        SceneManager.LoadScene(4);
    }
    public void Red() {
        SceneManager.LoadScene(16);
    }
}
