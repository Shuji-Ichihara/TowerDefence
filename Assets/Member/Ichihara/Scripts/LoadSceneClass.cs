using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneClass : MonoBehaviour
{
    public void SceneChangeLap()
    {
        var sceneIndex = SceneManager.GetActiveScene().buildIndex;
        switch (sceneIndex)
        {
            case 0:
                SceneChangeManager.Instacnce.ChangeScene(1);
                break;
            case 2:
                SceneChangeManager.Instacnce.ChangeScene(0);
                break;
            case 3:
                SceneChangeManager.Instacnce.ChangeScene(0);
                break;
            default:
                break;
        }
    }
}
