using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private readonly float leftLimit = -35;
    private readonly float bottomLimit = -10;

    void DogDestroy() {
        if (transform.position.x < leftLimit) {
            Destroy(gameObject);
        }
    }
    void BallDestroy() {
        if (transform.position.y < bottomLimit) {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        DogDestroy();
        BallDestroy();
    }
}
