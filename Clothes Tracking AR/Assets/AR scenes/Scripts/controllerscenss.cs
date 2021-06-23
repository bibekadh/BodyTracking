using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class controllerscenss : MonoBehaviour
{

    public void Sceneloader(int index)
    {
        SceneManager.LoadScene(index);
    }
}
