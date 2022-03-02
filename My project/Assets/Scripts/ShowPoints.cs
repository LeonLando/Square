using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPoints : MonoBehaviour
{
    [SerializeField] private Text _pointsText;
    private void Awake()
    {
        _pointsText = GetComponent<Text>();
    }

    void Update()
    {
        _pointsText.text = GlobalPoints.Points.ToString();  
    }
}
