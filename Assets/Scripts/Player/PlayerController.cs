using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Managers;

public class PlayerController : MonoBehaviour
{
    public InputManager myInputs;

    private Rigidbody2D rig;
    public Animator anim;
    public Transform body;

    private Vector2 movement;

    public float speedPlayer;

    [SerializeField] private bool isRight;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        Inputs();
        SetAnimations();
        Flip();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void Inputs()
    {
        movement = myInputs.input.Player.Move.ReadValue<Vector2>().normalized;

        if (movement.x > 0)
        {
            isRight = true;
        }
        else if (movement.x < 0)
        {
            isRight = false;
        }
    }

    private void MovePlayer()
    {
        rig.velocity = new Vector2(movement.x * speedPlayer, movement.y * speedPlayer);
    }

    void Flip()
    {
        if (isRight)
        {
            body.localScale = new Vector3(1.00846f, body.localScale.y, body.localScale.z);
        }
        else
        {
            body.localScale = new Vector3(-1.00846f, body.localScale.y, body.localScale.z);
        }


    }

    private void SetAnimations()
    {
        anim.SetFloat("walkSpeed", movement.magnitude);
    }
}
