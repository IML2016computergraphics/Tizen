using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class temperature : MonoBehaviour
{
    public GameObject Snowman;
    public float Temp = 0.0f;
    public Text txt;
    float Timevalue = 10.0f;
    public float posX, posY, posZ = 1.0f;
    public float NposX, NposY, NposZ = 0.0f;
    public GameObject scoreboard;
    public Text Score;
    public static int check = 1;

    // Use this for initialization
    void Start()
    {
        check = 1;
        txt.text = Temp.ToString();
        StartCoroutine(temper());
        StartCoroutine(ttem());
        Temp = Random.Range(23.0f, 39.0f);
    }
    IEnumerator ttem()
    {
        while (true)
        {
            if(Snowman.transform.position.z < 0)
            {
                Temp = Random.Range(23.0f, 39.0f);
                yield return new WaitForSeconds(3);
            }
            else
            {
                Temp = Random.Range(-10.0f, 10f);
                yield return new WaitForSeconds(3);
            }

        }

    }
    IEnumerator temper()
    {

        while (true)
        {

            if (Temp < 30 && Temp >0)
            {
                Snowman.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
            }
            if(Temp >30)
            {
                Snowman.gameObject.transform.localScale -= new Vector3(0.12f, 0.12f, 0.12f);

            }
            if (Snowman.gameObject.transform.localScale.x == 0.0f)
            {
                check = 0;
                Snowman.SetActive(false);
                scoreboard.SetActive(true);
                Score.text = "GAMEOVER" + "\n" + "점수 : " + itemGageBar.scorepoint.ToString();
            }
            yield return new WaitForSeconds(1);
        }


    }
    // Update is called once per frame
    void Update()
    {
        txt.text = Mathf.Round(Temp).ToString() + "℃";
        //Snowman.gameObject.transform.localScale.x > 0

    }
}