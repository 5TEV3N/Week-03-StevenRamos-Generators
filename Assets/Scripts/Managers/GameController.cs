using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //  This Script takes care of the spawning of objects and camera position
    public Vector3 fromDirection;
    public Vector3 toDirection;

    [Header ("Collections")]
    //  Collection of the objects
    public Transform[] installationObjectsCollections;
    public Transform[] cameraCollection;

    [Header("Positions in Scene")]
    //  Where the objects will be placed in the scene
    public Transform[] camOrientations;
    public Transform[] objSpawnPosition;

    void Start()
    {
        //OBJECT SECTION
        Transform objSpawnArray = installationObjectsCollections[Random.Range (0,installationObjectsCollections.Length)]; // from index 0 to the end length of the array randomly
        Transform objSpawn = Instantiate(objSpawnArray);
        Transform objSpawnPositionArray = objSpawnPosition[Random.Range(0, objSpawnPosition.Length)]; // gets the index of the spawn position

        objSpawn.SetParent(objSpawnPositionArray); // sets the objects from objSpawn into the spawn position
        objSpawn.localPosition = Vector3.up; // place them (0,1,0)
        objSpawn.localRotation = Quaternion.FromToRotation(fromDirection, toDirection); //

    }

    public void Reset()
    {
        SceneManager.LoadScene(0); //   Resets Game
    }
}
