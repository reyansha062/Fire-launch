using UnityEngine;

public class SafeZone : MonoBehaviour
{
    public float shrinkSpeed = 2f;
    public float minimumSize = 20f;
    public float damagePerSecond = 10f;

    private float currentSize;

    void Start()
    {
        currentSize = transform.localScale.x;
    }

    void Update()
    {
        if(currentSize > minimumSize)
        {
            currentSize -= shrinkSpeed * Time.deltaTime;

            transform.localScale =
            new Vector3(currentSize, 1, currentSize);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        HealthSystem player =
        other.GetComponent<HealthSystem>();

        if(player != null)
        {
            player.TakeDamage(
            damagePerSecond * Time.deltaTime);
        }
    }
}
