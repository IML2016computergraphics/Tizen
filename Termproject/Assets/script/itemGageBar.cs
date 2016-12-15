using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class itemGageBar : MonoBehaviour {

	// Use this for initialization


    public GameObject snowman;
    public GameObject snowflake;
    public Slider itemgage;
    public Text score;
    public static int scorepoint;
    public int check;
    IEnumerator coroutine;

    void Start()
    {
        check = 0;  
        score.text = "0";
        coroutine = supermode();        
    }
    public IEnumerator supermode()
    {
        while (true)
        {
            snowman.gameObject.tag = "supermode";
            snowman.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            itemgage.value -= 0.2f;
            yield return new WaitForSeconds(1);
     
        }
        
    }

    void OnTriggerEnter(Collider snowflake)
    {
        if (snowflake.gameObject.tag == "item")
        {
            itemgage.value += 0.1f;
            scorepoint += 100;
        }
    }
    
    void Update()
    {
       
       score.text = scorepoint.ToString();
       GameObject SnowmanHead = snowman.transform.FindChild("Head").gameObject;
       GameObject Snowmanleftarm = snowman.transform.FindChild("leftarm").gameObject;
       GameObject Snowmanrightarm = snowman.transform.FindChild("rightarm").gameObject;


        if (itemgage.value == 1)
        {
            Snowman_move.moveSpeed = 0.4f;
            Camera_move.moveSpeed = 0.4f;
            snowman.gameObject.tag = "supermode";
            Snowmanleftarm.SetActive(false);
            SnowmanHead.SetActive(false);
            Snowmanrightarm.SetActive(false);
            snowman.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            check = 1;        StartCoroutine(coroutine);
        }
        if(itemgage.value == 0)
        {
            Snowman_move.moveSpeed = 0.2f;
            Camera_move.moveSpeed = 0.2f;
            snowman.gameObject.tag = "Player";
            SnowmanHead.SetActive(true);
            Snowmanleftarm.SetActive(true);
            Snowmanrightarm.SetActive(true);
            snowman.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            check = 0;      StopCoroutine(coroutine);
        }
    }
}
