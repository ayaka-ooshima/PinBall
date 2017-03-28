using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    //
    private HingeJoint myHingeJoint;

    //
    private float defaultAngle = 20;
    //
    private float flickAngle = -20;


    // Use this for initialization
    void Start()
    {
        //
        this.myHingeJoint = GetComponent<HingeJoint>();

        //
        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        //
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }
        //
        if(Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        //
        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
          
            SetAngle(this.defaultAngle);


            //
            for(int i = 0; i < Input.touches.Length; i++)
            {
                //配列の中のi番目のタッチ情報を取り出している
                Touch touch = Input.touches[i];
            }
        }
    }
    //
    public void SetAngle (float angle)
    {
        JointSpring JointSpr = this.myHingeJoint.spring;
        JointSpr.targetPosition = angle;
        this.myHingeJoint.spring = JointSpr;

    }
}
