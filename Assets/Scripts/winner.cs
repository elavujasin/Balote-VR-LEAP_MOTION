using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winner : MonoBehaviour
{
    public GameObject[] balls;
    public GameObject referenceBall;
    public static int player = 0, textActive = 0;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {


    }

    public float Distance(GameObject ball)
    {
        return Mathf.Sqrt(Mathf.Pow(ball.transform.position.x - referenceBall.transform.position.x, 2)
                           + Mathf.Pow(ball.transform.position.z - referenceBall.transform.position.z, 2));
    }

    public void Winner()
    {
        winner.textActive = 1;
        GameObject.Find("Main Camera").transform.position = new Vector3(0.3f, 3f, 1.7f);
        Camera.main.transform.rotation = Quaternion.Euler(90, 0, 0);
        float min = float.MaxValue;
        int mini = 0;
        for (int i = 0; i < 4; i++)
        {
            if (min > Distance(balls[i]))
               {min = Distance(balls[i]);
                mini = i;}
                
            else if (min == Distance(balls[i]))
               {if (i % 2 == mini % 2)
                    mini = i;
                else
                    mini = -1;}    
        }
        winner.player = mini;
    }


}

