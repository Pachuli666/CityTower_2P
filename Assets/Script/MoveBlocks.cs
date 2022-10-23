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
        body.velocity = new Vector3(speed,0, 0);

        var pos = transform.position;
        var ship_x = transform.position.x;

        //SI EL CUBO PASA EL LIMITE REGRESA AL ORIGEN
        if (ship_x > 3.3f)
        {
            pos.x = -3.3f;
            transform.position = pos;
        }

        if (ship_x < -3.3f)
        {
            pos.x = 3.3f;
            transform.position = pos;
        }


    }
      

}
