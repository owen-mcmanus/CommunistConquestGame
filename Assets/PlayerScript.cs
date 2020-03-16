using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private bool isTurn = true;

    private RollDieScript roll;
    public Text textOut;

    [HideInInspector]
    public string curSpace;
    [HideInInspector]
    public int moveSpaces = 0;
    [HideInInspector]
    public int resP = 10;
    [HideInInspector]
    public int milP = 30;
    [HideInInspector]
    public int indP = 30;

    public int playerNum = 1;

    private Text resPoint;
    private Text milPoint;
    private Text indPoint;

    private void Awake()
    {
        roll = GameObject.Find("Canvas").transform.Find("RollDie").GetComponent<RollDieScript>();
        if(roll == null) { Debug.LogError("No gameobject found for roll"); }

        resPoint = GameObject.Find("Canvas").transform.Find("Stats").transform.Find("ResPoints").GetComponent<Text>();
        indPoint = GameObject.Find("Canvas").transform.Find("Stats").transform.Find("IndPoints").GetComponent<Text>();
        milPoint = GameObject.Find("Canvas").transform.Find("Stats").transform.Find("MilPoitns").GetComponent<Text>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        resPoint.text = "Respect: " + resP;
        indPoint.text = "Industrial: " + indP;
        milPoint.text = "Military: " + milP;

        textOut.text = moveSpaces.ToString();
        if (isTurn)
        {
            if(roll.randNum > 0)
            {
                moveSpaces = roll.randNum;
                roll.randNum = 0;
            }
            if(moveSpaces > 0)
            {

            }
        }
    }

}
