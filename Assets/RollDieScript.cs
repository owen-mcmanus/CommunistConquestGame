using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollDieScript : MonoBehaviour
{
    [HideInInspector]
    public int randNum = 0;

    public Button ownbutt;
    
    void Start()
    {
        ownbutt.onClick.AddListener(Roll);
    }

    void Update()
    {
        
    }

    void Roll()
    {
        randNum = Random.Range(1, 4);
    }
}
