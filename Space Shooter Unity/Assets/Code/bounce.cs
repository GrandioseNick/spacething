using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public Rigidbody2D _rigidbody2D;
    private Vector3 _prevposition;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void LateUpdate()
    {
        Vector3 tempPosition = Camera.main.WorldToScreenPoint(transform.position);

        if (tempPosition.x < 0 || tempPosition.x > Screen.width)
        {
            transform.position = _prevposition;
            _rigidbody2D.velocity = new Vector2(-_rigidbody2D.velocity.x, _rigidbody2D.velocity.y);
        }
        if (tempPosition.y < 0 || tempPosition.y > Screen.height)
        {
            transform.position = _prevposition;
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, -_rigidbody2D.velocity.y);
        }

        _prevposition = transform.position;
    }
}
