using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public int demage = 1;

    private Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position  = Vector2.MoveTowards(transform.position,player.position, speed * Time.deltaTime);
    }
}
