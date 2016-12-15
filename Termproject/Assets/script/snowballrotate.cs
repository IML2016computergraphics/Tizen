using UnityEngine;
using System.Collections;

public class snowballrotate : MonoBehaviour
{
    public float turnSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
