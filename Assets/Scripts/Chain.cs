using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    public static Chain portal;
    
    public Rigidbody2D body;
    public GameObject obj;

    private void Awake()
    {
        portal = this;
        body= GetComponent<Rigidbody2D>();
        obj= GetComponent<GameObject>();    
    }
}
