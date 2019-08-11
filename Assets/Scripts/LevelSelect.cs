using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Stage1 ()
    {
        SceneManager.LoadScene(0);
    }
    public void Stage2()
    {
        SceneManager.LoadScene(1);
    }
    public void LevelS()
    {
        SceneManager.LoadScene(2);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(3);
    }
}
