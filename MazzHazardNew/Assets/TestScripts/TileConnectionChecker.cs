//using Unity.AI.Navigation;
//using UnityEngine;
//using UnityEngine.AI;

//public class TileConnectionChecker : MonoBehaviour
//{
//    public GameObject spawnerTile;
//    public GameObject goalTile;
//    public GameObject pathTile;

//    private bool tilesConnected = false;

//    void Update()
//    {
//        // Check if your tiles are connected.
//        if (AreTilesConnected(spawnerTile, goalTile, pathTile) && !tilesConnected)
//        {
//            tilesConnected = true;

//            // Trigger NavMesh generation.
//            navMeshSurface.BuildNavMesh();
//        }
//    }

//    bool AreTilesConnected(GameObject tile1, GameObject tile2, GameObject tile3)
//    {
//        // Implement your logic to check if the tiles are connected.
//        // This will depend on your specific setup.
//        // Return true if they are connected, otherwise return false.
//    }
//}
