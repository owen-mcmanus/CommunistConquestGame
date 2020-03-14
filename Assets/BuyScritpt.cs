using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyScritpt : MonoBehaviour
{
    public Button ownbutt;
    public bool wantbuy = false;
    void Start()
    {
        ownbutt.onClick.AddListener(Buy);
    }

    void Update()
    {
        wantbuy = false;
    }

    void Buy()
    {
        wantbuy = true;
    }
}
