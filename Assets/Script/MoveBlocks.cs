using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlocks : MonoBehaviour
{

    //VARIABLE
    public float speed;
    private Rigidbody2D body;
    public bool Gravity = false;



    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        LoopMove();

        if (Input.GetKey(KeyCode.Space))
        {
            speed = 0;
            body.mass = 15;
            body.gravityScale = 30;
        }


    }


    public void LoopMove()
    {
        //USAMOS EL RIGIDBODY QUE DECLARAMOS,MODIFICAMOS SU VELOCIDAD Y DIRECCIONALIDAD
        body.velocity = new Vector3(speed, 0, 0);

        //ESTAS VARIABLES GUARDARAN DETERMINARA LOS LIMITES DE MOVIMIENTO
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
