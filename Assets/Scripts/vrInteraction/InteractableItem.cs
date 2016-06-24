using UnityEngine;
using System.Collections;

public class InteractableItem : MonoBehaviour {
    public Rigidbody rigidbody;

    private bool currentlyInteracting;

    private WandController attatchedWand;

    //Object Variables
    public float velocityFactor = 20000f;
    public float rotationFactor = 400f;
    private Transform interactionPoint;
    private Vector3 posDelta;
    private Quaternion rotationDelta;
    private float angle;
    private Vector3 axis;

	// Use this for initialization
	void Start () {
        //initialize rigid body
        rigidbody = GetComponent<Rigidbody>();
        //set interaction point
        interactionPoint = new GameObject().transform;
        //set velocity + Rotation factors to be relevant to mass
        velocityFactor /= rigidbody.mass;
        rotationFactor /= rigidbody.mass;
	}
	
	// Update is called once per frame
	void Update () {
	    if(attatchedWand && currentlyInteracting)
        {
            posDelta = attatchedWand.transform.position - interactionPoint.position;
            this.rigidbody.velocity = posDelta * velocityFactor * Time.deltaTime;

            rotationDelta = attatchedWand.transform.rotation * Quaternion.Inverse(interactionPoint.rotation);
            rotationDelta.ToAngleAxis(out angle, out axis);

            if (angle > 180)
            {
                angle -= 360;
            }

            this.rigidbody.angularVelocity = (Time.fixedDeltaTime * angle * axis) * rotationFactor;

        }
	}

    public void BeginInteraction(WandController wand)
    {
        attatchedWand = wand;
        interactionPoint.position = wand.transform.position;
        interactionPoint.rotation = wand.transform.rotation;
        interactionPoint.SetParent(transform, true);

        currentlyInteracting = true;
    }

    public void EndInteraction(WandController wand)
    {
        if (wand == attatchedWand)
        {
            attatchedWand = null;
            currentlyInteracting = false;
        }
    }

    public bool IsInteracting()
    {
        return currentlyInteracting;
    }
}
