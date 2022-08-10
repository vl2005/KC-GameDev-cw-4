using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;
    public Text inctext;
    public int inc = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void scoreup()
    {
        score += inc ;
        scoretext.text = score.ToString();

    }
    public void shop()
    {
        if(score >= 10)
        {
            score -= 10 ;
            inc += 1 ;
            scoretext.text = score.ToString();
            inctext.text = "inc= " + inc;
            print("+1 inc purchased new inc = " + inc);
        }
        else
        {
            print("your score is low");
        }
    }



}
