using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class GameManager : MonoBehaviour
{
    [Range(1, 2)]
    [SerializeField]
    private int playerCount;

    [SerializeField] private GameObject levelPrefab;
    private InputManager inputManager;
    private Vector3 levelPositionPlayerOne = new Vector3(0, 0, 0);
    private Vector3 levelPositionPlayerTwo = new Vector3(10, 0, 0);
    private GameObject levelOne;
    private GameObject levelTwo;
    private Camera cameraOne;
    private Camera cameraTwo;

    private void Awake()
    {
        inputManager = gameObject.GetComponent<InputManager>();
        
        levelOne = Instantiate(levelPrefab, levelPositionPlayerOne, Quaternion.identity);
        inputManager.OnPlayerOnePressLeft += levelOne.GetComponentInChildren<Paddle>().OnPressKeyLeft;
        inputManager.OnPlayerOnePressRight += levelOne.GetComponentInChildren<Paddle>().OnPressKeyRight;
        inputManager.OnPressStart += levelOne.GetComponentInChildren<Ball>().OnStartKeyPressed;

        if (playerCount == 2)
        {
            levelTwo = Instantiate(levelPrefab, levelPositionPlayerTwo, Quaternion.identity);

            inputManager.OnPlayerTwoPressLeft += levelTwo.GetComponentInChildren<Paddle>().OnPressKeyLeft;
            inputManager.OnPlayerTwoPressRight += levelTwo.GetComponentInChildren<Paddle>().OnPressKeyRight;
            inputManager.OnPressStart += levelTwo.GetComponentInChildren<Ball>().OnStartKeyPressed;

            cameraOne = levelOne.GetComponentInChildren<Camera>();
            cameraTwo = levelTwo.GetComponentInChildren<Camera>();

            cameraOne.rect = new Rect(0, 0, 0.5f, 1);
            cameraTwo.rect = new Rect(0.5f, 0, 0.5f, 1);
        }
    }
}
