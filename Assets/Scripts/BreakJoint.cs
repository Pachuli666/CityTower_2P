using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BreakJoint : MonoBehaviour
{
    public static BreakJoint portal;

    public Transform InitialPos;
    
    public Rigidbody2D body;
    
    public HingeJoint2D union;

    public bool NewCube;

    public GameObject sqare;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        union = GetComponent<HingeJoint2D>(); 

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            union.enabled = false;
            NewCube= true;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Respawn")
        {
            var cubo = Instantiate(sqare, InitialPos.position,InitialPos.rotation);
            union.connectedAnchor = cubo.transform.position;
            union.enabled = true;
            NewCube = false;
        }
    }




}
