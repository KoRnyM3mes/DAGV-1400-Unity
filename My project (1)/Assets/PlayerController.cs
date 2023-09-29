using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float gravity = 9f;

    private CharacterController controller;

    private bool isJumping = false;
    
    private float turnsmoother = 0.1f;
    private float turnvelocity;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Debug.Log("I am alive!");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontalInput, -gravity * Time.deltaTime , verticalInput).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float playerangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, playerangle, ref turnvelocity, turnsmoother);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            
            controller.Move(direction * moveSpeed * Time.deltaTime);
        }
        

        if (Input.GetButtonDown("Jump"));
        { 
            isJumping = true;
            return;
        }
    }
}
