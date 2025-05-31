using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    float timer = 2;
    public float spawnRate = 2;

    private void Update()
    {

        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        Vector3 randomPosition = new Vector3(transform.position.x, Random.Range(-3, 3), transform.position.z);

        Instantiate(pipe, randomPosition, transform.rotation);
    }
}
