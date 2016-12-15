using UnityEngine;
using System.Collections;

public class snowballdestroy : MonoBehaviour {
    public GameObject snoball;
    public GameObject eraser;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame

        void OnTriggerEnter(Collider eraser)
    {
            if (eraser.gameObject.tag == "eraser")
            {
                Stage2.bcount--;
                Destroy(gameObject);
            }

        }
}
