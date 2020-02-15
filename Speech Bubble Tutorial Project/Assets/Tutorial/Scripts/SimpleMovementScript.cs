using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovementScript : MonoBehaviour {

	[SerializeField] private float movementSpeed = 5f;

	private float horizontal;

    private bool interacting;

    // Update is called once per frame
    void Update()
    {
        if (!interacting)
        {
            horizontal = Input.GetAxis("Horizontal");

            transform.position += new Vector3(horizontal * movementSpeed * Time.deltaTime, 0, 0);
        }
    }

    public void ToggleInteraction()
    {
        interacting = !interacting;
    }
}
