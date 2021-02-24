using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustParticle: MonoBehaviour
{
    public SpriteRenderer sprite;
    public float movementSpeed;
    private float _fadespeed;
    private float _scale;

    void Start()
    {
        _fadespeed = Random.Range(0.1f, 0.2f);
        _scale = Random.Range(0.1f, 0.2f);
        transform.localScale = new Vector3(_scale, 1);
    }
    void Update()
    {
        if (sprite.color.a > 0)
        {
            float newAlpha = sprite.color.a - _fadespeed;
            sprite.color = new Color(sprite.color.r, sprite.color.g, sprite.color.b, newAlpha);
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

        }
        else
        {
            Destroy(gameObject);
        }
    }
}
