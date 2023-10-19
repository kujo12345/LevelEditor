using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathing : MonoBehaviour
{
    public Transform[] points;
    public Block[] blocks;

    public void GetWaypoints()
    {
        blocks = FindObjectsOfType<Block>();

        foreach (var block in blocks)
        {

            if (block.isWayPoint)
            {
                points[block.wayPointIndex] = block.transform;
            }
        }
    }

    void Awake()
    {
        GetWaypoints();
    }

}