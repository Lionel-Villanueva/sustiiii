using NUnit.Compatibility;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseEnemy : MonoBehaviour, IDamageable
{
    public int LiveEnemy = 5;
    private void Update()
    {
        
    }
    public void GetTarget(Transform player)
    {

    }
    public void TakeDamage(int amount)
    {
        LiveEnemy -= amount;
        if (LiveEnemy <= 0)
        {
            Dead();
        }
        Debug.Log("PLAYER RECIBIO DAÑO");
    }
    private void Dead()
    {
        Destroy(gameObject);
    }
}
