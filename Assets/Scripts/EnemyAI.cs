using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;
    public float attackDistance = 10f;

    void Update()
    {
        float distance =
        Vector3.Distance(
        transform.position,
        player.position);

        if(distance > attackDistance)
        {
            transform.LookAt(player);

            transform.position =
            Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime);
        }
    }
}
