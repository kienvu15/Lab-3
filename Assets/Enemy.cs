using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector3 targetPosition = new Vector3(-4, 0.09f);
    private Vector3 startPosition;
    private Vector3 currentTarget;
    

    private void Start()
    {
        startPosition = transform.position;
        currentTarget = targetPosition;
    }

    private void Update()
    {
        MoveToTarget();
    }

    private void MoveToTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, currentTarget, moveSpeed * Time.deltaTime);
        if ((Vector3)transform.position == (Vector3)currentTarget)
        {
            if (currentTarget == (Vector3)targetPosition)
            {
                currentTarget = startPosition;
            }
            
            else
            {
                currentTarget = targetPosition;
            }
        }



    }
}
