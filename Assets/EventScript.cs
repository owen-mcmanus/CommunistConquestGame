using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventScript : MonoBehaviour
{
    private PlayerScript ps;
    private GameObject player;

    public Text owntext;

    private bool i = false;
    private int randNum = 0;

    public int numPlayers;

    void Start()
    {
        player = GameObject.Find("Player1");
        ps = player.GetComponent<PlayerScript>();
    }

    void Update()
    {
        Debug.Log(i);
        if (ps.moveSpaces == 0 && i)
        {
            PullEvent();
            i = false;
        }
        if (ps.moveSpaces > 0) {i = true;}
    }

    void PullEvent()
    {
        randNum = Random.Range(1, 3);
        
        if(randNum == 1)
        {
            owntext.text = "Stalin is expelled from seminary school for failing to complete final exams. A random number is generated and you lose that many respect points.";
            for (int x = 0; x < numPlayers; x++)
                ps.resP -= Random.Range(1, 4);
        }
        if (randNum == 2)
        {
            owntext.text = "Stalin (5’5”) is called little squirt by president Truman (5’ 8”). If you have less than 10 respect points lose 2 military points and 2 industrial points.";
            if(ps.resP < 10)
            {
                ps.milP -= 2;
                ps.indP -= 2;
            }
        }
    }
}
