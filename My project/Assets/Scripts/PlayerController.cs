using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool LevelEnded = false;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            GlobalPoints.Points += 1;
            Destroy(collision.gameObject);

        }

    }
    private void Update()
    {
        if (!LevelEnded)
        {
            Vector2 _cursor = Input.mousePosition;
            _cursor = Camera.main.ScreenToWorldPoint(_cursor);


            if (_mouseDown)
            {
                this.transform.position = _cursor;
            }
            else
            {

            }

        }
    }

}  

