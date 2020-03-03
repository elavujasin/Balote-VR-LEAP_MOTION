using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Text : MonoBehaviour
{ private TextMeshProUGUI textmeshPro ;
    
    // Start is called before the first frame update
    void Start()
    {
        textmeshPro = GetComponent<TextMeshProUGUI>();
       

    }

    // Update is called once per frame
    void Update()
    { 
        if (winner.textActive == 1)
        {    if(winner.player== -1)
                textmeshPro.text = "It's a tie ";
            else if (winner.player % 2 == 0)
                textmeshPro.text = "player 1 won";
            else
                textmeshPro.text = "player 2 won";
        }
    }
}
