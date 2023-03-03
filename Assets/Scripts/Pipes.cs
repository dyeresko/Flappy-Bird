using UnityEngine;

public class Pipes : MonoBehaviour
{
    private float leftEdge;
    public float speed = 5.0f;

    private void Start()
    {
        leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero).x - 1.0f;
    }

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }

}
