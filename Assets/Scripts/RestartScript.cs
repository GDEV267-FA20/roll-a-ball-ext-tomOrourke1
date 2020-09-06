using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScript : MonoBehaviour
{

    Scene thisScene;

    private void Start()
    {
        thisScene = SceneManager.GetActiveScene();
    }

    public void loadItUp()
    {
        SceneManager.LoadScene(thisScene.name);
    }


}
