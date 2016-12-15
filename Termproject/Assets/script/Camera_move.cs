using UnityEngine;
using System.Collections;

public class Camera_move : MonoBehaviour
{

    Vector3 lookDirection;

    public static float moveSpeed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.W))
        {
            if (hitbyenemy.check == 1 && temperature.check ==1)
            {
                this.transform.Translate(Vector3.forward * moveSpeed * v, Space.World);
            }
        }

    }
}
