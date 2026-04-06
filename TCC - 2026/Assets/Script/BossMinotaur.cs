using UnityEngine;

public class BossMinotaur : MonoBehaviour
{
    public float speed = 3f;
    public int health = 20;

    private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position,speed * Time.deltaTime);
    }

    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Minotauro derrotado!");
        Destroy(gameObject);
    }
}
