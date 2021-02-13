using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nametags : MonoBehaviour
{
    public float moveSpeed;
    public GameObject target;
    private Transform rigTransform;
    void Start()
    {
        rigTransform = this.transform.parent;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(target == null){
            return;
        }
        Vector3 namePosition = Vector3.Lerp(rigTransform.position, target.transform.position, Time.deltaTime * moveSpeed);
        namePosition.y = 3.0f;
        rigTransform.position = namePosition; 
    }
}
