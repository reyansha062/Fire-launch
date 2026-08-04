using UnityEngine;

public class LootBox : MonoBehaviour
{
    public GameObject[] lootItems;

    private bool opened = false;

    void OnTriggerEnter(Collider player)
    {
        if(!opened)
        {
            OpenBox();
        }
    }

    void OpenBox()
    {
        opened = true;

        int item =
        Random.Range(0, lootItems.Length);

        Instantiate(
        lootItems[item],
        transform.position + Vector3.up,
        Quaternion.identity);

        Destroy(gameObject);
    }
}
