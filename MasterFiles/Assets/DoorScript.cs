using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float activationDistance = 5.0f;
    public float openingSpeed = 2.0f;
    public Animator animator;

    private Transform player;
    private bool isOpen = false;

    private void Start()
    {
        // Find the player object by tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Check the distance between the player and the door
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Open the door if the player is close enough and the door is not already open and the player presses "F"
        if (distanceToPlayer < activationDistance && !isOpen && Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("Open", true);
            isOpen = true;
        }
        // Close the door if the player is too far away and the door is open
        else if (distanceToPlayer >= activationDistance && isOpen && Input.GetKeyDown(KeyCode.F))
        {
            animator.SetBool("Open", false);
            isOpen = false;
        }
    }
}
