using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChekCircles : MonoBehaviour
{
    [SerializeField] private GameObject _endLevelPanel;
    [SerializeField] private PlayerController _square;
    void Update()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Circle");

        if (gameObjects.Length == 0)
        {
            _endLevelPanel.SetActive(true);
            _square.LevelEnded = true;
        }
    }
}
