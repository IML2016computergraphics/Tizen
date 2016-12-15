using UnityEngine;
using System.Collections;

public class DestroyPS : MonoBehaviour {

    ParticleSystem PS;
	// Use this for initialization
	void Start () {
        PS = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (PS.IsAlive() == false)
        {
            Destroy(gameObject);
        }
	}
}
