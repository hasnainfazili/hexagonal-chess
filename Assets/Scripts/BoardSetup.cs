// BoardSetup.cs
using UnityEngine;

public class BoardSetup : MonoBehaviour
{
    public GameObject tilePrefab;
    public int rows = 5; // Adjust rows and columns as needed
    public int columns = 5;

    private void Start()
    {
        CreateBoard();
    }

    void CreateBoard()
    {
        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < rows; y++)
            {
                // Position hexagonal tiles with offsets
                Vector3 position = new Vector3(x * 1.5f, y * 1.3f, 0);
                if (y % 2 != 0)
                    position.x += 0.75f;

                GameObject tile = Instantiate(tilePrefab, position, Quaternion.identity);
                tile.transform.parent = transform;
                tile.name = $"Tile_{x}_{y}";
                // Optionally store the tile in a 2D array for easy access
            }
        }
    }
}