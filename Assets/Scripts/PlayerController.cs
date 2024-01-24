using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
// TODO: import UnityEngine.InputSystem and UnityEngine.SceneManagement


public class PlayerController : MonoBehaviour
{
    // TODO: add component references

    Rigidbody rb;

    // TODO: add variables for speed, jumpHeight, and respawnHeight
    [SerializeField] float speed = 5.0f;
    [SerializeField] float jumpheight = 5.0f;

    // TODO: add variable to check if we're on the ground
    // bool ground = true;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: Get references to the components attached to the current GameObject
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: check if player is under respawnHeight and call Respawn()

    }

    void OnJump()
    {
        Jump();
        // TODO: check if player is on the ground, and call Jump()

    }

    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x,jumpheight,rb.velocity.z);
        // TODO: Set the y velocity to some positive value while keeping the x and z whatever they were originally

    }

    bool isflatten = false;
    void OnPancaking()
    {
        if (isflatten == false)
        {
            Pancaking();
            isflatten = true;
        }
        else
        {
            isflatten = false;
        }

    }

    private void Pancaking()
    {
        transform.localScale = new Vector3(transform.localScale.x * 2, transform.localScale.y / 2, transform.localScale.z * 2);
    }

    void OnMove(InputValue moveVal)
    {
        Vector2 direction = moveVal.Get<Vector2>();
        //TODO: store input as a 2D vector and call Move()
        Move(direction[0], direction[1]);
    }

    private void Move(float x, float z)
    {
        rb.velocity = new Vector3(x*speed, rb.velocity.y ,z*speed);
        // TODO: Set the x & z velocity of the Rigidbody to correspond with our inputs while keeping the y velocity what it originally is.

    }

    void OnCollisionEnter(Collision collision)
    {
        // This function is commonly useful, but for our current implementation we don't need it

    }

    void OnCollisionStay(Collision collision)
    {
        // TODO: Check if we are in contact with the ground. If we are, note that we are grounded

    }

    void OnCollisionExit(Collision collision)
    {
        // TODO: When we leave the ground, we are no longer grounded

    }

    private void Respawn()
    {
        // TODO: reload current scene

    }
}
