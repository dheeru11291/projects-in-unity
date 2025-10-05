using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidbody;
    public float moveSpeed;
    public LogicScript logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidbody.linearVelocity = Vector2.up * moveSpeed;
        }
        if (transform.position.y > 17|| transform.position.y < -17)
            logic.gameOver();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
