// Piece.cs
using UnityEngine;
using System.Collections.Generic;

public class Piece : MonoBehaviour
{
    public bool isKing;
    public bool isPlayerOnePiece;
    public Tile currentTile;

    public void ShowAvailableMoves()
    {
        // Assuming hexagonal adjacency, define movement range.
        List<Tile> availableMoves = HexChessGameManager.Instance.GetAdjacentTiles(currentTile);
        foreach (Tile tile in availableMoves)
        {
            if (!tile.isOccupied)
                tile.Highlight(Color.green);
        }
    }

    public void MoveTo(Tile newTile)
    {
        if (currentTile != null)
        {
            currentTile.isOccupied = false;
            currentTile.currentPiece = null;
            currentTile.ResetColor();
        }
        
        newTile.isOccupied = true;
        newTile.currentPiece = gameObject;
        currentTile = newTile;

        transform.position = newTile.transform.position;
    }
}