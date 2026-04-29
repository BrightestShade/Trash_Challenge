using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collector") //check if being touched by collecor
        {
            Destroy(gameObject); //destroy trash object
        }

    }
}
