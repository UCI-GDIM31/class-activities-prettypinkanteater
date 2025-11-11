using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _playerTransform;
    [SerializeField] private GameObject _player;


    public void EnableChasing(Transform player)
    {
        enabled = true;
        _playerTransform = _player.GetComponent<Transform>();
    }
   

    public void StopChasing()
    {
        enabled = false;
    }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _speed * Time.deltaTime);
    }
}
