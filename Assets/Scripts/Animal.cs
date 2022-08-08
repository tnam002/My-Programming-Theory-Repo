using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Rigidbody animalRigidBody;
    protected float jumpForce = 200;
    protected string name;

    // Start is called before the first frame update
    void Start()
    {
        animalRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Jump();
        } else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("right clicked");

        }
    }

    private void OnMouseEnter()
    {
    }

    private void OnMouseExit()
    {
        
    }

    virtual protected void Jump()
    {
        animalRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Force);
    }
}
