using UnityEngine;
using UnityEngine.AI;
//AI Movement
public class GameController : MonoBehaviour
{
    public Transform Target; //assign the trash
    public Transform Collection; //assign collection point
    public NavMeshAgent Agent; //assign the trash collector


    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(Target.position); //make trash collector move towards the trash
    }
}
