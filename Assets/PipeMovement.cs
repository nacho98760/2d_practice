using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    public float moveSpeed = 4f;

    private void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        deletePipeIfOutOfRange();
    }

    private void deletePipeIfOutOfRange()
    {
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
    }
}
