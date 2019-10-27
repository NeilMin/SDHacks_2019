using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public Rigidbody rb;
    public static int recycleOrNot;
   

    // The speed of ball should increase as the difficulity of the game increases.
    public float forwardForce = 100f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreControl.scoreNum = 5;
    }
    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        transform.Translate(4f * Time.deltaTime, 0, 0);

        if (this.transform.position.y < 0)
        {
            check();
            Debug.Log("check");
            //Destroy(gameObject);
        }

        if (this.transform.position.x < 0)
        {
            scoreControl.scoreNum--;
            Destroy(gameObject);
        }

        if ((this.transform.position.z > 1.2 && this.transform.position.y < 0))
        { 
            rb.velocity = Vector3.zero;
            if (gameObject.tag == "recycle")
            {
                scoreControl.scoreNum++;
            }
            else
            {
                scoreControl.scoreNum--;
            }
            Destroy(gameObject);
        }

        if ((this.transform.position.z < -1.2 && this.transform.position.y < 0))
        {
            rb.velocity = Vector3.zero;
            
            if (gameObject.tag == "harmful")
            {
                scoreControl.scoreNum++;
            }
            else
            {
                scoreControl.scoreNum--;
            }
            Destroy(gameObject);
        }
    }

    private void check()
    {
        if (gameObject.tag == "recycle" && transform.position.z > 0) {

        }

        //.Log("hi");
        if (gameObject.tag == "recycle" && transform.position.z < 0)
            Debug.Log("hi");

       
    }



}
