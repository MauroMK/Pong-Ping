using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : PlayerControll
{
    public bool canMoveVertical;

    protected override void HandleInput()
    {
        base.HandleInput();

        if (isPlayer1 && canMoveVertical)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");
        }
    }
}
