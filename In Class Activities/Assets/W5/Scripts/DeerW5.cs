using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...

public class DeerW5: MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private GameObject _player;

    // when variable type is class name it is an instance of a variable / object = so it uses class as template 

    void Start()
    {

        NavMeshAgent _navMeshAgent = GetComponent<NavMeshAgent>();

        _navMeshAgent.SetDestination(_transform.position);
    }
}