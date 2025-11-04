using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _player;

    public void EnableChasing()
    {
        enabled = true;
    }
    
    private void Update()
    {
        _playerTransform = _player.GetComponent<Transform>();
        transform.position = Vector3.MoveTowards(transform.position,_playerTransform.position, _speed * Time.deltaTime);
    }

    public void StopChasing()
    {
        enabled = false;
    }
}
