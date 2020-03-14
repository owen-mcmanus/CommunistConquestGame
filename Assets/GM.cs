using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    private BuyScritpt buybutt;
    private PlayerScript ps;
    private GameObject territory;
    private TerritoryScript ts;

    void Start()
    {
        buybutt = GameObject.Find("Canvas").transform.Find("Panel").transform.Find("Button").GetComponent<BuyScritpt>();
        ps = GameObject.Find("Player1").GetComponent<PlayerScript>();
    }

    void Update()
    {
        if (buybutt.wantbuy)
        {
            ts = GameObject.Find(ps.curSpace).GetComponent<TerritoryScript>();
            if (ps.milP >= ts.cost)
            {
                ps.milP = ps.milP - ts.cost;
                ts.owner = ps.playerNum;
            }
        }
    }
}
