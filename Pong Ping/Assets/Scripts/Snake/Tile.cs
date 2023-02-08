using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor;
    [SerializeField] private Color offSetColor;
    [SerializeField] private SpriteRenderer _renderer;

    public void Init(bool isOffset)
    {
        _renderer.color = isOffset ? offSetColor : baseColor;
        //* if we are offset lets set it to the offsetcolor, otherwise lets color the base color
    }

}
