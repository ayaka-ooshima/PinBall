using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //
    private float visiblePosZ = -6.5f;

    //
    private GameObject gameoverText;

    //
    private GameObject scoreText;
    //
    private int score;


    //
    void OnCollisionEnter(Collision cot)
    {
        //
        Debug.Log(cot.gameObject.name);
        if (cot.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        } else if (cot.gameObject.tag == "SmallStarTag")
        {
            score += 5;
        } else if (cot.gameObject.tag == "SmallCloudTag")
        {
            score += 20;
        }else if(cot.gameObject.tag == "LargeCloudTag")
        {
            score += 5;
        }

        scoreText.GetComponent<Text>().text =score.ToString();
    }



    // Use this for initialization
    void Start()
    {
        //
        this.gameoverText = GameObject.Find("GameOverText");
        //
        this.scoreText = GameObject.Find("ScoreText");

    }
     
    // Update is called once per frame
    void Update()
    {
        //
        if (this.transform.position.z < this.visiblePosZ)
        {
            //
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
