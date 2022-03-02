using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool _mouseDown = false;
    [SerializeField] private Transform _centrPoint;
    private void OnMouseDown()
    {
        _mouseDown = true;
    }
    private void OnMouseUp()
    {
        _mouseDown = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            GlobalPoints.Points += 1;
        }
    }
    private void Update()
    {
        Vector2 _cursor = Input.mousePosition;
        _cursor = Camera.main.ScreenToWorldPoint(_cursor);

        float dist = Vector2.Distance(_centrPoint.position, this.transform.position);

        if (_mouseDown)
        {
            this.transform.position = _cursor;
        }
        else
        {

        }
    }

}  

