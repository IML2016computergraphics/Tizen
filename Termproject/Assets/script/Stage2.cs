using UnityEngine;
using System.Collections;

public class Stage2 : MonoBehaviour
{

    public GameObject bsnowman;
    public GameObject snowball;
    public GameObject rabbit;
    public GameObject tiger;
    public GameObject bear;

    public float bspawnTime;

    float banimal_select;
    Vector3 bSpawn_Position;
    Vector3 aSpawn_Position;
    float aR_PosX;
    float aR_PosZ;
    float bR_PosX;
    float bR_PosZ;

    public static int bcount = 0;
    public static int acount = 0;


    // Use this for initialization
    void Start()
    {
        InvokeRepeating("snowballSpawn", bspawnTime, bspawnTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void snowballSpawn()
    {
        bR_PosX = Random.Range(0.0f, 20.0f);
        if (hitbyenemy.check == 1)
        {
            bR_PosZ = bsnowman.transform.position.z + 30.0f;

            bSpawn_Position = new Vector3(bR_PosX, 0.5f, bR_PosZ);
            if (bsnowman.transform.position.z > 0.0f && bcount < 20)
            {
                Instantiate(snowball, bSpawn_Position, transform.rotation);
                bcount++;
            }
        }
        aR_PosX = -5.0f;
        if (hitbyenemy.check == 1)
        {
            if (bsnowman.transform.position.z >0.0f)
            {
                aR_PosZ = Random.Range(bsnowman.transform.position.z, bsnowman.transform.position.z + 20.0f);
            }
            if (bsnowman.transform.position.z >= -40.0f && bsnowman.transform.position.z < 0.0f)
            {
                aR_PosZ = Random.Range(-40.0f, 0.0f);
            }

            aSpawn_Position = new Vector3(aR_PosX, 0.5f, aR_PosZ);
            if (acount < 20 && bsnowman.transform.position.z > 0.0f)
            {
                banimal_select = Random.Range(0.0f, 3.0f);
                if (banimal_select < 1.0f)
                {
                    Instantiate(rabbit, aSpawn_Position, transform.rotation);
                    acount++;
                }
                if (banimal_select >= 1.0f && banimal_select < 2.0f)
                {
                    Instantiate(tiger, aSpawn_Position, transform.rotation);
                    acount++;
                }
                if (banimal_select >= 2.0f && banimal_select <= 3.0f)
                {
                    Instantiate(bear, aSpawn_Position, transform.rotation);
                    acount++;
                }
            }
        }
    }
}