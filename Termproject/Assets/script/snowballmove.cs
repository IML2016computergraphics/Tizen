using UnityEngine;
using System.Collections;

public class snowballmove : MonoBehaviour
{

    public float moveSpeed = 0.2f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        snowball_Move();
    }

    void snowball_Move()
    {
        transform.Translate(0.0f, 0.0f, - moveSpeed * Time.deltaTime);
    }
}