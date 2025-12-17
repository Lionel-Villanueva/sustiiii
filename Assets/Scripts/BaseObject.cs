using UnityEngine;

public class BaseObject : MonoBehaviour, IDamageable
{
    public void TakeDamage(int amount)
    {
        Destroy(gameObject);
    }
}
