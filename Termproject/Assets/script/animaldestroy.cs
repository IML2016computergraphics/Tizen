using UnityEngine;
using System.Collections;

public class animaldestroy : MonoBehaviour
{

    public GameObject animal;
    public GameObject eraser;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider eraser)
    {

        if (eraser.gameObject.tag == "eraser")
        {
            Stage1.count--;
            Destroy(gameObject);
        }

    }
}
