using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interactionStart : MonoBehaviour
{
    public void Button()

    {
        Debug.Log("test");
        SceneManager.LoadScene(sceneName: "MainScene");
    
    }

}
