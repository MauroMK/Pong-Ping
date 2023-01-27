using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroller : MonoBehaviour
{
    private float borderY = 10.21f;
    private float scrollSpeed = -4f;

    void Update()
    {
        transform.position += new Vector3(0, scrollSpeed * Time.deltaTime); //* Scrolls the background

        if (transform.position.y <= -borderY)
        {
            //* If the position of the background reaches the specified Y position, the background will move to the new position
            transform.position = new Vector3(transform.position.x, borderY);
        }
    }
}
