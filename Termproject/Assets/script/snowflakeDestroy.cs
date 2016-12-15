using UnityEngine;
using System.Collections;

public class snowflakeDestroy : MonoBehaviour {

    public GameObject snowflake;
    public GameObject eraser;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerEnter(Collider eraser)
    {

        if (eraser.gameObject.tag == "eraser")
        {
            ItemRespawn.count--;
            Destroy(gameObject);
        }

    }
}
