using UnityEngine;
using System.Collections;

public class animaldestroy_bywall : MonoBehaviour
{

    public GameObject animal;
    public GameObject wall;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider wall)
    {

        if (wall.gameObject.tag == "wall")
        {
            Stage1.count--;
            Destroy(gameObject);
        }

    }
}
