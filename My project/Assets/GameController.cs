using UnityEngine;
using UnityEngine.AI;
//AI Movement
public class GameController : MonoBehaviour
{
    public GameObject Target; // assign a scene object or an instantiated prefab
    public Transform Collection; // assign collection point
    public NavMeshAgent Agent; // assign the trash collector

    // Update is called once per frame
    void Update()
    {
        if (Agent == null || Target == null) return;

        Agent.SetDestination(Target.transform.position); // make trash collector move towards the trash
    }

    // Call this to change the target at runtime (pass an instantiated prefab or scene object)
    public void SetTarget(GameObject t)
    {
        Target = t;
    }
}
