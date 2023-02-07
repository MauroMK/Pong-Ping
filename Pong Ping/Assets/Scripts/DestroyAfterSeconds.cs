using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterSeconds : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1);
    }
}
