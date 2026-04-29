using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    // My Array that will allow me to assign prefabs in the inspector to spawn
    public GameObject[] myObjects;

    // optional: assign this in the Inspector, otherwise it will FindFirstObjectByType at runtime
    public GameController gameController;

    public float timer = 0;
    public float spawnInterval = 10f; // the seconds between spawns

    
    void Start()
    {
        if (gameController == null)
        {
            // Replace deprecated FindObjectOfType with FindFirstObjectByType
            gameController = FindFirstObjectByType<GameController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; // my float timer starts at 0 and increases by 1 every second
        if (timer > spawnInterval) // If the timer reaches about the spawn interval (10) it runs the logic in my if statement
        {
            timer = 0; // resets the timer
            int randomIndex = Random.Range(0, myObjects.Length); // Picks a random gameobject from my prefabs that I added to the array to spawn
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-1, 5)); // Determines a random position in the availible 3D space determined by the numbers to instantiate the object into

            GameObject instance = Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity); // instantiates the object into the position

            // If we have a GameController available, assign the spawned instance as the target
            if (instance != null)
            {

                if (gameController == null)
                {
                    // Replace deprecated FindObjectOfType with FindFirstObjectByType
                    gameController = FindFirstObjectByType<GameController>();
                }


                if (gameController != null)
                {
                    gameController.SetTarget(instance);
                }
            }
        }
    }
}
