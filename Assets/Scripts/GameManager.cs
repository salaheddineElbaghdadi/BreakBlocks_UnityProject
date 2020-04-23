using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Range(1, 2)]
    [SerializeField]
    private int playerCount;

    [SerializeField] private GameObject levelPrefab;
    private Vector3 levelPositionPlayerOne = new Vector3(0, 0, 0);
    private Vector3 levelPositionPlayerTwo = new Vector3(10, 0, 0);
    private GameObject levelOne;
    private GameObject levelTwo;
    private Camera cameraOne;
    private Camera cameraTwo;

    private void Awake()
    {
        if (playerCount == 1)
        {
            levelOne = Instantiate(levelPrefab, levelPositionPlayerOne, Quaternion.identity);
        }
        else if (playerCount == 2)
        {
            levelOne = Instantiate(levelPrefab, levelPositionPlayerOne, Quaternion.identity);
            levelTwo = Instantiate(levelPrefab, levelPositionPlayerTwo, Quaternion.identity);

            cameraOne = levelOne.GetComponentInChildren<Camera>();
            cameraTwo = levelTwo.GetComponentInChildren<Camera>();

            cameraOne.rect = new Rect(0, 0, 0.5f, 1);
            cameraTwo.rect = new Rect(0.5f, 0, 0.5f, 1);
        }
    }
}
