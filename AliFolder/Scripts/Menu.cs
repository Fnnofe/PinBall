using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public int Level1Number;

    //public void PlayGame()
    //{
    //    SceneManager.LoadScene(1);
    //}

    IEnumerator PlayGame1() 
    {
        yield return new WaitForSeconds(1.0f);
    
        SceneManager.LoadScene(Level1Number);
    }

    public void PlayGame ()
    {
        StartCoroutine(PlayGame1());
    }

    public void GoBackMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartTutorial()
    {
        SceneManager.LoadScene(8);
    }

     public void RestartLevel1()
    {
        SceneManager.LoadScene(2);
    }
}
