using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public Transform vrCamera;
    public float toppleAngle = 30.0f; //If you look down 30 deg -> walk
    public float speed = 3.8f;
    public bool moveForward;

    private CharacterController cc;

    // Start is called before the first frame update
    void Start()
    {
        //Hat movement 
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(vrCamera.eulerAngles.x >= toppleAngle && vrCamera.eulerAngles.x<90){
            moveForward = true;
        }
        else{
            moveForward = false;
        }
        if(moveForward){
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward*speed);
        }
    }
}
