using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void Stage1 ()
    {
        SceneManager.LoadScene(1);
    }
    public void Stage2()
    {
        SceneManager.LoadScene(2);
    }
    public void LevelS()
    {
        SceneManager.LoadScene(3);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
