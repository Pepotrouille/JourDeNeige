using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSceneManager : MonoBehaviour
{
    public void PushChangeScene(string nomScene)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nomScene);
    }

    public void PushQuit()
    {
        Application.Quit();
    }
}
