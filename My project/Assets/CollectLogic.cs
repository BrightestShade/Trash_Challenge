using UnityEngine;
using Unity.UI;
public class CollectLogic : MonoBehaviour
{
    ScoreManager scoreManager; // references the ScoreManager script

    void OnTriggerEnter(Collider other) // when an object enters the trigger
    {
        if (other.CompareTag("Collectable")) // checks if the object entering the trigger has tag "collectable" 
        {
            Destroy(other.gameObject); // destroys Collectable
            scoreManager.AddPoints(); // accesses ScoreManager script and calls AddPoints method
        }
    }

}
