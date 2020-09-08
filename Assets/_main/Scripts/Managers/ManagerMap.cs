using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMap : MonoBehaviour
{
    public static ManagerMap managerMap;
    public Vector2Int gridSize;
    public SquareCell cellPrefab;

    public SquareCell[] cells;

    private void Awake()
    {
        managerMap = this;

        cells = new SquareCell[gridSize.y * gridSize.x];

        for (int z = 0, i = 0; z < gridSize.y; z++)
        {
            for (int x = 0, j = 0; x < gridSize.x; x++)
            {
                CreateCell(x, z, i++, j++);
            }
        }

        MasterManager.masterManager.Init();
    }

    void Start()
    {
        Camera.main.transform.position = new Vector3(gridSize.x / 2, gridSize.y / 2, -10);
    }
    
    void CreateCell(int x, int y, int i, int j)
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
