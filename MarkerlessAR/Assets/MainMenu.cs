using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
     public void PlayGame()
     {
          SceneManager.LoadScene("AR");
     }

     public void QuitGame()
     {
          Application.Quit();
     }

     public void Back()
     {
          SceneManager.LoadScene("UI");
     }
}
