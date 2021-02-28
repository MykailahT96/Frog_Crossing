using UnityEngine;

public class Car : MonoBehaviour
{

    public Rigidbody2D rigidbody;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    float speed = 1f;

    void Start()
    {
        speed = Random.Range(minSpeed ,maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2 (transform.right.x, transform.right.y);
        rigidbody.MovePosition(rigidbody.position + forward * Time.fixedDeltaTime * speed);
    }

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

}
