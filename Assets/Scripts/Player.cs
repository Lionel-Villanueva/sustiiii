using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : BaseEntity, IDamageable
{
    public int live = 10;
    public float speed;
    private Rigidbody2D rb;

    public string scene;
    private Vector2 moveDirection;

    public GameObject prefabBullet;
    private Vector2 direcitonMouse;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        PlayerInput.OnMove += Move;
        PlayerInput.OnMousePosition += MousePosition;
        PlayerInput.OnShoot += Shoot;
    }

    private void Shoot()
    {
        GameObject go = Instantiate(prefabBullet, transform.position, transform.rotation);
        go.GetComponent<BulletController>().Direction(direcitonMouse);
    }

    private void MousePosition(Vector2 obj)
    {
        direcitonMouse = Camera.main.ScreenToWorldPoint(obj);
        direcitonMouse = direcitonMouse - (Vector2)transform.position;
        direcitonMouse = direcitonMouse.normalized;
    }

    private void OnDisable()
    {
        PlayerInput.OnMove -= Move;
        PlayerInput.OnMousePosition -= MousePosition;
        PlayerInput.OnShoot -= Shoot;
    }

    private void Move(Vector2 vector)
    {
        moveDirection = vector;
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            TakeDamage(1);
            Destroy(collision.gameObject);
        }
    }
    public void TakeDamage(int amount)
    {
        live -= amount;
        if (live<=0)
        {
            Dead();
        }
        Debug.Log("PLAYER RECIBIO DAÑO");
    }
    private void Dead()
    {
        SceneManager.LoadScene(scene);
    }
}


