using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public float speed = 5f;
    public int maxDistance;

    public Vector2 position;

    void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        Move();
        Interactions();
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + 1.25f, 0, 1.25f * (ManagerMap.managerMap.gridSize.x - 1)), transform.position.y, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - 1.25f, 0, 1.25f * (ManagerMap.managerMap.gridSize.x - 1)), transform.position.y, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + 1.25f, 0, 1.25f * (ManagerMap.managerMap.gridSize.y - 1)), 0);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y - 1.25f, 0, 1.25f * (ManagerMap.managerMap.gridSize.y - 1)), 0);
        }
    }

    public void Interactions()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            position = transform.position;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = position;
        }
    }
}
