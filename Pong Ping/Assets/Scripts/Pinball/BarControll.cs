using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControll : MonoBehaviour
{
    private Animator anim;

    private string leftMovement = "MoveL";
    private string rightMovement = "MoveR";

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger(leftMovement);
        }

        if (Input.GetMouseButtonDown(1))
        {
            anim.SetTrigger(rightMovement);
        }
    }
}
