using UnityEngine;

public class GunSystem : MonoBehaviour
{
    public Camera playerCamera;
    public float damage = 25f;
    public float range = 100f;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;

        if(Physics.Raycast(playerCamera.transform.position,
            playerCamera.transform.forward,
            out hit, range))
        {
            HealthSystem enemy =
            hit.transform.GetComponent<HealthSystem>();

            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
        }
    }
}
