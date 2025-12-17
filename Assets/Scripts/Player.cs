using UnityEngine;

public class Player : BaseEntity, IDamageable
{
    public int live = 10;

    private void Update()
    {
        TakeDamage(1);
    }

    public void TakeDamage(int amount)
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            live -= amount;
            Debug.Log("PLAYER RECIBIO DAÑO");
        }
    }
}


