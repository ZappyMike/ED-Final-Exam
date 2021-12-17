using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Scene_Change : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void win()
    {
        SceneManager.LoadScene("win");
    }

    public void ded()
    {
        SceneManager.LoadScene("ded");
    }

    public void menu()
    {
        SceneManager.LoadScene("menu");
    }
}
