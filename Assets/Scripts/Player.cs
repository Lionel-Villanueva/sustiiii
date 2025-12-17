using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : BaseEntity, IDamageable
{
    public int live = 10;
    public string scene;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            TakeDamage(1);
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


