using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
{
    public float speed;
    private Rigidbody2D body;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        body.velocity = new Vector3(Mathf.Clamp(speed,0f,1f), 0, 0);
        
    }
      

}
