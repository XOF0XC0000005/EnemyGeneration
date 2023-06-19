using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CharacterController))]
public class EnemyMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float _speed = 2f;

    private CharacterController _controller;
    private Animator _animator;
    private int _forward = Animator.StringToHash("forward");

    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat(_forward, 2);

        Vector3 move = transform.forward * 1;

        _controller.Move(move * _speed * Time.deltaTime);
    }
}
