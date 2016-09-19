using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //  This Script takes care of the spawning of objects and camera position

    public Transform[] installationObjectsCollections;
    public Transform[] objSpawnPosition;

    public Transform[] cameraCollection;
    public Transform cam;

    void Start()
    {
        //OBJECT SECTION
        Transform objSpawnArray = installationObjectsCollections[Random.Range (0,installationObjectsCollections.Length)]; // from index 0 to the end length of the array randomly
        Transform objSpawn = Instantiate(objSpawnArray);
        Transform objSpawnPositionArray = objSpawnPosition[Random.Range(0, objSpawnPosition.Length)]; // gets the index of the spawn position

        objSpawn.SetParent(objSpawnPositionArray); // sets the objects from objSpawn into the spawn position
        objSpawn.localPosition = Vector3.up; // place them (0,1,0)
        objSpawn.rotation = Random.rotation; // Random rotation

        //CAMERA SECTION
        Transform camSpawnArray = cameraCollection[Random.Range(0, cameraCollection.Length)];
        cam.SetParent(camSpawnArray);
        cam.localPosition = Vector3.up; // no idea but having the local position to (0,1,0) makes the camera properly face the right direction
        cam.localRotation = Quaternion.identity; // takes the same rotation as the parent

    }

    public void Reset()
    {
        SceneManager.LoadScene(0); //   Resets Game
    }
}
