using UnityEngine;

public class BulletController : MonoBehaviour
{
    Rigidbody2D rb;
    private Vector2 direction;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = direction * 10f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            GameManager.Instance.AddScore(10);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
    public void Direction(Vector2 value)
    {
        direction = value;
    }

}
