// HexChessGameManager.cs
using UnityEngine;
using System.Collections.Generic;

public class HexChessGameManager : MonoBehaviour
{
    public static HexChessGameManager Instance;
    public Tile[,] boardTiles; // Set in Inspector or dynamically
    public Piece SelectedPiece;

    private void Awake()
    {
        Instance = this;
    }

    public void SelectPiece(Piece piece)
    {
        if (SelectedPiece != null)
        {
            DeselectPiece();
        }
        
        SelectedPiece = piece;
        SelectedPiece.ShowAvailableMoves();
    }

    public void DeselectPiece()
    {
        SelectedPiece = null;
        foreach (Tile tile in boardTiles)
        {
            tile.ResetColor();
        }
    }

    public void MoveSelectedPieceTo(Tile tile)
    {
        if (SelectedPiece != null)
        {
            SelectedPiece.MoveTo(tile);
            DeselectPiece();
        }
    }

    public List<Tile> GetAdjacentTiles(Tile centerTile)
    {
        List<Tile> adjacentTiles = new List<Tile>();
        
        // Assuming a hex grid with specific neighbors - adjust based on tile indices
        // This example assumes boardTiles is a 2D array with hexagonal adjacency logic.
        // Add appropriate adjacency checks here.

        return adjacentTiles;
    }
}