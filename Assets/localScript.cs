using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class localScript : MonoBehaviour
{

    public enum StickState
    {
        ChangePosition, Rotate, Push
    }

    public StickState currentStickState;


    // Start is called before the first frame update
    void Start()
    {
        currentStickState = StickState.ChangePosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentStickState = StickState.Rotate;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentStickState = StickState.ChangePosition;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            currentStickState = StickState.Push;
          
        }
    }


    void FixedUpdate()
    {
        if(currentStickState == StickState.Push)
        {
           
            float speed = 0;
            if (Input.GetKey(KeyCode.W))
            {
                speed = 0.01f;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                speed = - 0.01f;
            }
            transform.localPosition = new Vector3(0, 0, transform.localPosition.z + speed);
            Debug.Log("Push");
           
        }
           
    }






}
