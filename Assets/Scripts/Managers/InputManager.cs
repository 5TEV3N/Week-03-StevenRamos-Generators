using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    GameController gameController;

    void Awake()
    {
        gameController = GameObject.FindGameObjectWithTag("T_GameController").GetComponent<GameController>(); //    Refference the GameController
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameController.Reset(); //  Redirects to GameController
        }
    }
}
