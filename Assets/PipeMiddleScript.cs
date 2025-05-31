using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public GameManagerScript GameManager;
    void Start()
    {
        GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.addScore();
        }
    }
}
