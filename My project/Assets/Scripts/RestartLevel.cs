using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public void GoRestartLevel()
    {
        GlobalPoints.Points = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
