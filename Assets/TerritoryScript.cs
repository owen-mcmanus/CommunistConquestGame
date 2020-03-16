using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TerritoryScript : MonoBehaviour
{
    public string territoryName;
    public int cost;
    public int retMil;
    public int retInd;
    public int retRes;
    public string[] boarderingTerr;

    [HideInInspector]
    public int owner = 0;

    private GameObject player;
    private PlayerScript ps;
    private GameObject terr;
    private EventScript events;

    private Text terrname;
    private Text terrcost;
    private Text terrgain;
    private BuyScritpt buybutt;

    bool i = true;

    void Start()
    {
        player = GameObject.Find("Player1");
        ps = player.GetComponent<PlayerScript>();
        ps.curSpace = "Moscow";

        terrname = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("Name").GetComponent<Text>();
        terrcost = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("Cost").GetComponent<Text>();
        terrgain = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("Gain").GetComponent<Text>();
        buybutt = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("Button").GetComponent<BuyScritpt>();
        events = GameObject.Find("Canvas").transform.Find("EventPanel").transform.Find("CardText").GetComponent<EventScript>();
    }

    void Update()
    {
        if(ps.curSpace == territoryName)
        {
            terrname.text = "Name: " + territoryName;
            terrcost.text = "Cost: " + cost;
            terrgain.text = "Gain: " + retMil +" / " + retInd + " / " + retRes;
        }
        
        if(owner == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 255f, 255f);
            if(ps.moveSpaces == 0 && i)
            {
                ps.milP += retMil;
                ps.indP += retInd;
                ps.resP += retRes;
                i = false;
            }
        }
        if(ps.moveSpaces > 0) { i = true; }
        retMil += events.territoryMod;
    }

    void OnMouseDown()
    {
        if(ps.moveSpaces > 0)
        {
            for (int i = 0; i < boarderingTerr.Length; i++)
            {
                if (ps.curSpace == boarderingTerr[i])
                {
                    Debug.Log(ps.curSpace);
                    player.transform.position = transform.position;
                    ps.curSpace = territoryName;
                    ps.moveSpaces--;
                }
            }
        }
    }
}
