using UnityEngine;
using System.Collections;

public class animal_move : MonoBehaviour {

    public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        animal_Move();
	}

    void animal_Move()
    {
         transform.Translate(moveSpeed * Time.deltaTime, 0.0f, 0.0f);

    }
}
