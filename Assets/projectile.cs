using UnityEngine;

public class projectile : MonoBehaviour
{
    public Transform player;
    public float speed;
    private Vector3 playerPosition;

    public void Start()
    {
        playerPosition = player.position;
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
    if (collision.gameObject.CompareTag("Player"))
        {
    Destroy(gameObject);
        }

  }
}
