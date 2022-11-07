using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakJoint : MonoBehaviour
{
    public Rigidbody2D body;
    public DistanceJoint2D distanceJoint;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        distanceJoint = GetComponent<DistanceJoint2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            distanceJoint.enabled = false;


            body.transform.position = new Vector3(Mathf.Clamp(body.position.x, -1.9f, 1.9f), transform.position.y, transform.position.z);

        }


    }
}
