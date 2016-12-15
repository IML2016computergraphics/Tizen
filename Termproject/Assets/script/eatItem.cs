using UnityEngine;
using System.Collections;


public class eatItem : MonoBehaviour {
    public ParticleSystem effect;
    public GameObject snowman;
    public GameObject snowflake;

    
    void OnTriggerEnter(Collider snowman)
    {
        if (snowman.gameObject.tag == "Player" || snowman.gameObject.tag == "supermode")
        {
            Destroy(gameObject);

            Instantiate(effect, transform.position, Quaternion.identity);

            snowman.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            
        }
    }


}
