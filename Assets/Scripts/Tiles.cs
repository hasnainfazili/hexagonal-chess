using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool isOccupied;
    public GameObject currentPiece;

    private SpriteRenderer spriteRenderer;
    private Color defaultColor;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultColor = spriteRenderer.color;
    }

    public void Highlight(Color color)
    {
        spriteRenderer.color = color;
    }

    public void ResetColor()
    {
        spriteRenderer.color = defaultColor;
    }

    private void OnMouseDown()
    {
        if (HexChessGameManager.Instance.SelectedPiece != null)
        {
            HexChessGameManager.Instance.MoveSelectedPieceTo(this);
        }
    }
}