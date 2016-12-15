using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Help : MonoBehaviour
{

    public Button help;
    public Button script;
    public GameObject helptext;

    void Start()
    {
        helptext.SetActive(false);
    }

    public void helptextopen()
    {
        helptext.SetActive(true);
    }

    public void helptextclose()
    {
        helptext.SetActive(false);
    }

    void Update()
    {
        help.onClick.AddListener(helptextopen);
        script.onClick.AddListener(helptextclose);
    }

}