using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodCamera : MonoBehaviour
{
    private Rigidbody mRigidbody;

    [SerializeField] private float mCameraSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        this.mRigidbody = this.GetComponent<Rigidbody>();
        if (this.mRigidbody == null)
            print("GOD CAMERA : Start() : Cant fetch rigibody component. Please attach one.");
    }

    // Update is called once per frame
    void Update()
    {
        if (mRigidbody == null)
            return; 

        if (Input.GetKey(KeyCode.Z))
        {
            this.mRigidbody.AddForce(this.transform.forward * Time.deltaTime * this.mCameraSpeed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.mRigidbody.AddForce(-this.transform.right * Time.deltaTime * this.mCameraSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.mRigidbody.AddForce(-this.transform.forward * Time.deltaTime * this.mCameraSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.mRigidbody.AddForce(this.transform.right * Time.deltaTime * this.mCameraSpeed);
        }
        
        Vector3 mouseRotation;
        mouseRotation.x = -Input.GetAxis("Mouse Y");
        mouseRotation.y =  Input.GetAxis("Mouse X");
        mouseRotation.z = 0;

        transform.Rotate(mouseRotation * Time.deltaTime * mCameraSpeed);
    }
}
