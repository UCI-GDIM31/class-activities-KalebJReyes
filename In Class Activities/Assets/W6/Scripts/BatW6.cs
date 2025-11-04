using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    public Transform _target;

    private void Start() 
    {
        Chase();
    }

    private void Update() 
    {
        transform.position = Vector3.MoveTowards(transform.position, 
                                                _target.position, 
                                                _speed * Time.deltaTime);
    }

    public void Chase() 
    {
        enabled = true;

    }

    public void StopChase() 
    {
        enabled = false;
    }
}
