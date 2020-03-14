using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private bool isTurn = true;

    private RollDieScript roll;
    private int moveSpaces = 0;
    private string curSpace;

    private void Awake()
    {
        roll = GameObject.Find("Canvas").transform.Find("RollDie").GetComponent<RollDieScript>();
        if(roll == null) { Debug.LogError("No gameobject found for roll"); }
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (isTurn)
        {
            if(roll.randNum > 0)
            {
                moveSpaces = roll.randNum;
                roll.randNum = 0;
                Debug.Log(moveSpaces);
            }
            if(moveSpaces > 0)
            {

            }
        }
    }

}
