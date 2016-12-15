using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class start_exit : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void move()
    {
        SceneManager.LoadScene(1);
    }

    public void exitclick()
    {
        Application.Quit();
    }

    public void returntoHome()
    {
        SceneManager.LoadScene(0);
    }

}