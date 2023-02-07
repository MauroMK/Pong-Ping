using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    void Awake()
    {
        LeanTween.moveLocalY(this.gameObject, -4f, 4f).setEaseInOutSine().setLoopPingPong();
        LeanTween.moveLocalX(this.gameObject, 0, 2f).setEaseInOutSine().setLoopPingPong();
    }
}
