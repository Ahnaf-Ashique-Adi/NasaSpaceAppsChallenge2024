using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{

    public void playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void quitgame() 
    {
        Application.Quit();
    }
}
