using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    
    public Slider mySlider;
    public float acceleration = 625f;
    public float maxSpeed = 4375f;

    private Rigidbody rigidBody;
    private KeyCode[] inputKeys;
    private Vector3[] directionsForKeys;

    // Start is called before the first frame update
    void Start()
    {
       inputKeys = new KeyCode[] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
       directionsForKeys = new Vector3[] { Vector3.forward, Vector3.left, Vector3.back, Vector3.right};
       rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for(int i = 0; i < inputKeys.Length; i++){
            var key = inputKeys[i];
            if(Input.GetKey(key)){
                Vector3 movement = directionsForKeys[i] * acceleration * Time.deltaTime;
                movePlayer(movement);
            }
        }
        changeGameSpeed();
        
    }
    void movePlayer(Vector3 movement){
        if(rigidBody.velocity.magnitude * acceleration > maxSpeed){
            rigidBody.AddForce(movement * -1); 
        }
        else{
            rigidBody.AddForce(movement);
        }
    }
    void changeGameSpeed(){
        var pastValue = 5f;
        if(pastValue > mySlider.value && maxSpeed > 0 && maxSpeed < 6500f && acceleration > 0 && acceleration < 700f){
            maxSpeed = maxSpeed / mySlider.value;
            acceleration = acceleration - (mySlider.value * 10);
            pastValue = mySlider.value;
        }
        else if(pastValue < mySlider.value && maxSpeed > 0 && maxSpeed < 6500f && acceleration > 0 && acceleration < 700f){
            maxSpeed = maxSpeed * mySlider.value;
            acceleration = acceleration + (mySlider.value * 10);
        }
        else{

        }
    }
    
}

