using NUnit.Compatibility;
using UnityEngine;

public class BaseEnemy : MonoBehaviour, IDamageable
{
    public int LiveEnemy = 5;

    public void TakeDamage(int amount)
    {

    }
}
