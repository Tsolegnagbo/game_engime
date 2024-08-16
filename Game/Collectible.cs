using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Logic for collecting the item
            Debug.Log("Item Collected!");
            Destroy(gameObject);
        }
    }
}
