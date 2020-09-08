using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script that handles the map generation.
/// We have the static reference to this script in the var "managerMap"
/// The gridSize handles the width and height of the grid.
/// cellPrefab is the gameobject of each cell on the map that is being instantiated.
/// cells is the array of all the cells that were generated in the world.
/// </summary>

public class ManagerMap : MonoBehaviour
{
    public static ManagerMap managerMap;
    public Vector2Int gridSize;
    public SquareCell cellPrefab;

    SquareCell[] cells;

    private void Awake()
    {
        managerMap = this;

        cells = new SquareCell[gridSize.y * gridSize.x];

        for (int z = 0, i = 0; z < gridSize.y; z++)
        {
            for (int x = 0; x < gridSize.x; x++)
            {
                //Nested "For" to generate the cell on x and y axis.
                CreateCell(x, z, i++);
            }
        }

        MasterManager.masterManager.Init();
    }

    void Start()
    {
        // Positioning of the camera at the center of the grid
        Camera.main.transform.position = new Vector3(gridSize.x / 2, gridSize.y / 2, -10);
    }
    
    // Function to instantiate the cell at the given position
    void CreateCell(int x, int y, int i)
    {
        Vector3 position;
        position.x = x * 1.25f;
        position.y = y * 1.25f;
        position.z = 0;

        SquareCell cell = cells[i] = Instantiate(cellPrefab);
        cell.transform.SetParent(transform, false);
        cell.transform.localPosition = position;
    }
}
