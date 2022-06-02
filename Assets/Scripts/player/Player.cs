using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PhysicsMovement _move;
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    private Jump jump;

    public delegate void EnterInPlaneTrigger();

    public event EnterInPlaneTrigger EnterTrigger;

    private void Start()
    {
        _move = gameObject.AddComponent<PhysicsMovement>();
        jump = gameObject.GetComponent<Jump>();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
         Vector3 targer = new Vector3(0,0,1);

        if (Input.GetKeyDown("space"))
        {
            jump.PlayAnimations(_rigidbody, 1f);
        }
        _move.Move(targer, _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        EnterTrigger?.Invoke();
    }
}
