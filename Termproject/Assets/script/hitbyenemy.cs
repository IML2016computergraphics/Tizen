using UnityEngine;
using UnityEngine.UI;

public class hitbyenemy : MonoBehaviour {
    
    public GameObject Snowman;
    public GameObject hitted_snowman;
    Vector3 spawn_position;
    public static int check = 1;
    public GameObject scoreboard;
    public Text Score;

    // Use this for initialization
    void start()
    {
        check = 1;
    }
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider enemy)
    {

        if (enemy.gameObject.tag == "animal" || enemy.gameObject.tag =="snowball")
        {
            if (Snowman.gameObject.tag == "Player")
            {
                check = 0;
                spawn_position = new Vector3(Snowman.transform.position.x, Snowman.transform.position.y, Snowman.transform.position.z);
                Destroy(gameObject);
                Instantiate(hitted_snowman, spawn_position, transform.rotation);
                scoreboard.SetActive(true);
                Score.text = "GAMEOVER" + "\n" + "점수 : " + itemGageBar.scorepoint.ToString();
            }
       
            
        }

    }
}
