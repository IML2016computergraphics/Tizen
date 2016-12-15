using UnityEngine;
using System.Collections;

public class Stage1 : MonoBehaviour {

    public GameObject snowman;
    public GameObject rabbit;
    public GameObject wildboar;
    public GameObject tiger;
    public GameObject bear;

    public float spawnTime;
    Vector3 Spawn_Position;
    float R_PosX;
    float R_PosZ;
    float animal_select;
    public static int count = 0 ;


    // Use this for initialization
    void Start () {
	        InvokeRepeating("animalSpawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {

    }

    void animalSpawn()
    {

        if (hitbyenemy.check == 1)
        {
            R_PosX = -5.0f;
            if (snowman.transform.position.z < -40.0f && snowman.transform.position.z > -196.0f)
            {
                R_PosZ = Random.Range(snowman.transform.position.z, snowman.transform.position.z + 20.0f);
            }
            if (snowman.transform.position.z >= -40.0f && snowman.transform.position.z < 0.0f)
            {
                R_PosZ = Random.Range(-40.0f, 0.0f);
            }
            Spawn_Position = new Vector3(R_PosX, 0.5f, R_PosZ);


            if (count < 20 && snowman.transform.position.z < 0.0f)
            {
                animal_select = Random.Range(0.0f, 4.0f);
                if (animal_select < 1.0f)
                {
                    Instantiate(rabbit, Spawn_Position, transform.rotation);
                    count++;
                }
                if (animal_select >= 1.0f && animal_select < 2.0f)
                {
                    R_PosX = -5.0f;
                    Spawn_Position = new Vector3(R_PosX, 0.5f, R_PosZ);
                    Instantiate(wildboar, Spawn_Position, transform.rotation);
                    count++;
                }
                if (animal_select >= 2.0f && animal_select < 3.0f)
                {
                    Instantiate(tiger, Spawn_Position, transform.rotation);
                    count++;
                }
                if (animal_select >= 3.0f && animal_select <= 4.0f)
                {
                    Instantiate(bear, Spawn_Position, transform.rotation);
                    count++;
                }
              
            }
  
        }
    }
}
