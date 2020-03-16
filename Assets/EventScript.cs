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

    private DeathScript death;
    public int numPlayers;

    [HideInInspector]
    public int territoryMod = 0;

    void Start()
    {
        player = GameObject.Find("Player1");
        ps = player.GetComponent<PlayerScript>();
        death = GameObject.Find("20").transform.Find("Stalin").GetComponent<DeathScript>();
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
        randNum = Random.Range(1, 12);
        
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
        if (randNum == 3)
        {
            owntext.text = "Stalin hires brilliant architects who design execution centers with sloping floors. Blood is now easier to clean up and everyone gains 1 military point.";
            for (int x = 0; x < numPlayers; x++)
                ps.milP++;
        }
        if (randNum == 4)
        {
            owntext.text = "Stalin is nominated for the Nobel Peace prize. Take one free favor card.";
            //must add later
            Debug.LogError("Need to add later after adding industrial cards");
        }
        if (randNum == 5)
        {
            owntext.text = "Stalin had a stroke but his guards, out of fear, didn’t call a doctor for twelve hours. Stallin will lose 5 health. Turns out this actually happened. This lead to his death in March 5, 1953";
            death.health -= 5;
        }
        if (randNum == 6)
        {
            owntext.text = "USSR is now part of the League of Nations. The cost to capture countries goes down by a military point.";
            territoryMod = -1;
        }
        if (randNum == 7)
        {
            owntext.text = "Berlin Blockade, you must give 5 military points to prevent the allis airlift.";
            for (int x = 0; x < numPlayers; x++)
                ps.milP -= 5;
        }
        if (randNum == 8)
        {
            owntext.text = "The Soviet Union tests its first atomic bomb. 3 military points for everyone.";
            for (int x = 0; x < numPlayers; x++)
                ps.milP += 3;
        }
        if (randNum == 9)
        {
            owntext.text = "Stalin changes his birthday and gains compliments from his comrades. Each comrade gains one respect point.";
            for (int x = 0; x < numPlayers; x++)
                ps.resP += 1;
        }
        if (randNum == 10)
        {
            owntext.text = "It is discovered that Stalin never said “A single death is a tragedy, a million dead is a statistic” All comrades lose one respect point.";
            for (int x = 0; x < numPlayers; x++)
                ps.resP -= 1;
        }
        if (randNum == 11)
        {
            owntext.text = "Dilan Mitchell, a person of high power in the Soviet government, is found to be a traitor. You must witness his execution. All players move to Moscow. Stalin relishes watching the traitor die, but chokes on a shashlik during the ceremony and has to go to his doctor. Stalin loses three health points.";
            death.health -= 3;
            for (int x = 0; x < numPlayers; x++)
            {
                player.transform.position = new Vector3(-5.28f, 0.34f, -1.98f);
                ps.curSpace = "Moscow";
            }
        }
    }
}
