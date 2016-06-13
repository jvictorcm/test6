using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {

    Animator anim;
    //bool vira = true;
    //int turn0 = 0;
    //Vector3 Vector3;
    float timeDance = 2.0f;
    float timeMove = 2.0f;
    float timeTurn = 6.0f;
    Rigidbody rb;
    //int random = 0;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
}
	
	// Update is called once per frame
	void Update () {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("para"))
        {
            timeMove = 1.0f;
            timeDance = 1.0f;
            timeTurn = 3.0f;
            int sortDance = Random.Range(1, 9);
            int sortMove = Random.Range(1, 9);
            int sortTurn = Random.Range(1, 9);
            if (sortMove == 1 && timeMove > 0)
            {
                timeMove = -Time.deltaTime;
                anim.SetTrigger("move");
            }
            else
            {
                if (sortDance == 1 && timeDance > 0)
                {
                    timeDance = -Time.deltaTime;
                    anim.SetTrigger("dance");
                }
                else
                {
                    if (sortTurn == 1 && timeTurn > 0)
                    {
                        timeTurn = -Time.deltaTime;
                        anim.SetTrigger("turn");
                    }
                }
            }
        }


        if (anim.GetCurrentAnimatorStateInfo(0).IsName("move"))
        {
            //transform.Translate(Vector3.right * Time.deltaTime);
            //print("move");
            //rb.velocity = new Vector3(Random.Range(-1,2), Random.Range(-1, 2), Random.Range(-1, 2));
            rb.AddForce(Vector3.up *Time.deltaTime, ForceMode.Acceleration + 100);
            //print("move");
        }
        else
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("danca"))
            {
                //animação
            }else
            {
                if (anim.GetCurrentAnimatorStateInfo(0).IsName("roda"))
                {
                    transform.Rotate(Vector3.right, Random.Range(5, 30));
                    transform.Rotate(Vector3.down, Random.Range(5, 30));
                    transform.Rotate(Vector3.back, Random.Range(5, 30));
                    //print("roda");
                }
            }
        }

    }
}
