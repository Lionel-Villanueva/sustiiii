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

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        PlayerInput.OnMove += Move;
    }
    private void OnDisable()
    {
        PlayerInput.OnMove -= Move;
    }

    private void Move(Vector2 vector)
    {
        moveDirection = vector;
    }

    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            TakeDamage(1);
        }
    }
    private void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * speed;
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


