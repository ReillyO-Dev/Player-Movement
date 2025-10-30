using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Coins"))
        {
            Destroy(collision.gameObject);
        }
    }
}
