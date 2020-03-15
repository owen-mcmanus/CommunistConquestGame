using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    [HideInInspector]
    public int health = 20;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(((20-health)*.15f)-8.15f,4.55f,-1f);
    }
}
