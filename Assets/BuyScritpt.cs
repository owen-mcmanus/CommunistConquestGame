using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyScritpt : MonoBehaviour
{
    public Button ownbutt;

    [HideInInspector]
    public bool wantbuy;

    private TerritoryScript ts;
    private PlayerScript ps;

    void Start()
    {
        wantbuy = false;
        ownbutt.onClick.AddListener(Buy);
        
        ps = GameObject.Find("Player1").GetComponent<PlayerScript>();
    }

    void Update()
    {
        wantbuy = false;
    }

    void Buy()
    {
        wantbuy = true;
        ts = GameObject.Find(ps.curSpace).GetComponent<TerritoryScript>();
        if (ps.milP >= ts.cost && ts.owner == 0)
        {
            ps.milP = ps.milP - ts.cost;
            ts.owner = ps.playerNum;
        }
    }
}
