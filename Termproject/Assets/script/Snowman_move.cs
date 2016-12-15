using UnityEngine;
using System.Collections;

public class Snowman_move : MonoBehaviour {

    Vector3 lookDirection;
    public static float moveSpeed;

    public GameObject Snowman;

	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            lookDirection = v * Vector3.forward + h * Vector3.right;

            Snowman.transform.rotation = Quaternion.LookRotation(lookDirection);
            this.transform.Translate(Vector3.forward*moveSpeed*v,Space.World);
           
        }
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
        {

            lookDirection = v * Vector3.forward + h * Vector3.right;

            Snowman.transform.rotation = Quaternion.LookRotation(lookDirection);
            Snowman.transform.Translate(Vector3.right * moveSpeed * h, Space.World);
        }

    }
}
