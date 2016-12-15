using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class finishGame : MonoBehaviour
{
    public ParticleSystem effect;
    public GameObject snowman;
    public GameObject scoreboard2;
    public Text Score2;

    void OnTriggerEnter(Collider snowman)
    {

            if (snowman.gameObject.tag == "Player")
            {
                Destroy(gameObject);
              //  Instantiate(effect, transform.position, Quaternion.identity);
                scoreboard2.SetActive(true);
                Score2.text = "축하축하!" + "\n" + "점수 : " + itemGageBar.scorepoint.ToString();

            }


    }
}