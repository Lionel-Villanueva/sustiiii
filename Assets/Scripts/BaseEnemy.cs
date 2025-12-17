using UnityEngine;

public class BaseEnemy : MonoBehaviour, IDamageable
{
    public int LiveEnemy = 5;
    public float speed = 2f;

    private Transform target;

    private void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }

    public void GetTarget(Transform player)
    {
        target = player;
    }

    public void TakeDamage(int amount)
    {
        LiveEnemy -= amount;

        if (LiveEnemy <= 0)
        {
            GameManager.Instance.AddScore(10);
            Dead();
        }

        Debug.Log("ENEMY RECIBIO DAÑO");
    }

    private void Dead()
    {
        Destroy(gameObject);
    }
}
