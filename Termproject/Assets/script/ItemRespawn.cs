using UnityEngine;

public class ItemRespawn : MonoBehaviour
{
    public GameObject snowflake;
    public GameObject snowman;
    public float spawnTime = 1.0f;
    Vector3 Spawn_Position;
    float R_PosX;
    float R_PosZ;
    public static int count = 0;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    void Spawn()
    {
        R_PosX = Random.Range(-0.25f, 20.0f);
        R_PosZ = Random.Range(snowman.transform.position.z, snowman.transform.position.z + 40.0f);
        Spawn_Position = new Vector3(R_PosX, 1.0f, R_PosZ);

        if (hitbyenemy.check ==1 && count < 15 && snowman.transform.position.z > -196.0f)
        {
            Instantiate(snowflake, Spawn_Position, transform.rotation);
            count++;
        }
    }
}