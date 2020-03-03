using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPosition : MonoBehaviour
{
    public GameObject[] balls;
    public GameObject referenceBall;
    private int i = 0;
    private float timer = 0.0f;
    private Vector3 spherePosition;
    public static bool flag = true;
    private bool ballsSpeed = true,triggerEmpty=false;
    public winner _winner;
    // Start is called before the first frame update
    void Start()
    {
       
        for (int j = 0; j < 4; j++)
            balls[j].active = false;


         
    }

    // Update is called once per frame
    void Update()
    {
        
        for (int j = 0; j < 4; j++)
                if (balls[j].GetComponent<Rigidbody>().velocity.magnitude > 0.1)
                    ballsSpeed = false; 

        if (referenceBall.GetComponent<Rigidbody>().velocity.magnitude > 0.1)
                ballsSpeed = false;

        if (ballsSpeed && triggerEmpty)
                _winner.Winner();
        
        ballsSpeed = true;


        timer += Time.deltaTime;

        if (i <= 3 && ballPosition.flag == false && timer > 2.0f)
               {balls[i].transform.position = new Vector3(0.298f, -0.256f, 0.498f);
                balls[i].active = true;
                i++;}

        

       

    }

    
        void OnTriggerEnter(Collider otherCollider)
                {ballPosition.flag = true;}
      
        void OnTriggerExit(Collider otherCollider)
                {timer = 0;
      
                if (i <= 4 && ballPosition.flag == true)
                    ballPosition.flag = false;
      
                else if(i == 4)
                    triggerEmpty = true;}

        
       
    
}
   