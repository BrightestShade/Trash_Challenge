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
        if (Agent == null || Target == null) return; // if the agent is not assigned or missing AND/OR the Target is not assigned or missing, return the update

        Agent.SetDestination(Target.transform.position); // make trash collector move towards the trash
        
    }

    // Call this to change the target at runtime (pass an instantiated prefab or scene object)
    public void SetTarget(GameObject t) // sets the target for the AI nav mesh agent to be the trash
    {
        Target = t; // "t" is the last spawned instance of the trash cube prefab 
    }
}
