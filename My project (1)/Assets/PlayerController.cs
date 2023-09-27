using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9f;

    private CharacterController controller;
    private Vector3 moveDirection;

    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Debug.Log("I am alive!");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal") * moveSpeed;
        float veritcalinput = Input.GetAxis("Vertical") * moveSpeed;
    }
}
