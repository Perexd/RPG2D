using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public string nextUuid;
    public float speed = 5.0f;
    public const string HORIZONTAL = "Horizontal", VERTICAL = "Vertical";
    public static bool playerCreated;
    private float inputTol = 0.2f; // toleracia del input
    private float xInput, yInput;

    private bool isWalking;
    public Vector2 lasDirection;
    private Animator _animator;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        playerCreated = true;
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxisRaw(HORIZONTAL);
        yInput = Input.GetAxisRaw(VERTICAL);
        isWalking = false;

        if (Mathf.Abs (xInput) > inputTol)
        {
            _rigidbody.velocity = new Vector2(xInput * speed, 0);
            isWalking = true;
            lasDirection = new Vector2(xInput, 0);
        }
  
        if (Mathf.Abs (yInput) > inputTol)
        {
            _rigidbody.velocity = new Vector2(0, yInput * speed);
            isWalking = true;
            lasDirection = new Vector2(0, yInput);
        }
        
       
      
    }
    private void LateUpdate()
    {
        if (!isWalking)
        {
            _rigidbody.velocity = Vector2.zero;
        }

        _animator.SetFloat(HORIZONTAL, xInput);
        _animator.SetFloat(VERTICAL, yInput);
        _animator.SetFloat("LastHorizontal", lasDirection.x);
        _animator.SetFloat("LastVertical", lasDirection.y);
        _animator.SetBool("IsWalking", isWalking);
    }
  }