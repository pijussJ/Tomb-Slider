using UnityEngine;
using UnityEngine.Tilemaps;

public class Player : MonoBehaviour
{
    public Tilemap map;
    public Vector3Int pos;
    void Start()
    {
        pos = map.WorldToCell(transform.position);
    }

    void Update()
    {
        // RIGHT
        if (Input.GetKeyDown(KeyCode.D))
        {
            var targetPos = pos + Vector3Int.right;
            if (map.HasTile(targetPos)) return;

            pos = targetPos;
            transform.position = map.GetCellCenterWorld(targetPos);
            transform.eulerAngles = new Vector3(0, 0, 90);
        }

        // LEFT
        if (Input.GetKeyDown(KeyCode.A))
        {
            var targetPos = pos + Vector3Int.left;
            if (map.HasTile(targetPos)) return;

            pos = targetPos;
            transform.position = map.GetCellCenterWorld(targetPos);
            transform.eulerAngles = new Vector3(0, 0, 270);
        }

        // UP
        if (Input.GetKeyDown(KeyCode.W))
        {
            var targetPos = pos + Vector3Int.up;
            if (map.HasTile(targetPos)) return;

            pos = targetPos;
            transform.position = map.GetCellCenterWorld(targetPos);
            transform.eulerAngles = new Vector3(0, 0, 180);
        }

        // DOWN
        if (Input.GetKeyDown(KeyCode.S))
        {
            var targetPos = pos + Vector3Int.down;
            if (map.HasTile(targetPos)) return;

            pos = targetPos;
            transform.position = map.GetCellCenterWorld(targetPos);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}