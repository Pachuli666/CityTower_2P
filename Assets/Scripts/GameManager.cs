using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager door;

    public Rigidbody2D body;

    public HingeJoint2D joint;

    public Rigidbody2D chain;

    public GameObject cube;

    public bool NewCube;
}
