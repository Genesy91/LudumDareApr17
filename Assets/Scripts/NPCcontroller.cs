using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{

    public Vector2 forwardDirection;
    Vector2 realDirection;
    public float speed;

    Vector2 topLimit;
    Vector2 bottomLimit;

    public float timerLimit;
    float timer;

    // Use this for initialization
    void Start()
    {
        realDirection = NewDirection();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(realDirection * speed * Time.deltaTime);
        if (GotToTheLimit())
        {
            realDirection = NewDirection();
        }

        timer += Time.deltaTime;
        if (timer > timerLimit)
        {
            realDirection = NewDirection();
            timer = 0f;
        }

    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        timer = timerLimit + 1;
    }

    public Vector2 NewDirection()
    {
        float randomAngle;
        if (transform.position.y > topLimit.y)
        {
            randomAngle = Random.Range(-45f, 0f);
        }
        else if (transform.position.y < bottomLimit.y)
        {
            randomAngle = Random.Range(0f, 45f);
        }
        else
        {
            randomAngle = Random.Range(-45f, 45f);
        }
        Vector2 direction = Quaternion.Euler(0f, 0f, randomAngle) * forwardDirection;
        return direction;
    }

    public bool GotToTheLimit()
    {
        if (transform.position.y > topLimit.y || transform.position.y < bottomLimit.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetLimits(Vector2 top, Vector2 bottom)
    {
        topLimit = top;
        bottomLimit = bottom;
    }
}
