using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public Vector3 mousePosition3d;
    //public float acceleration;
    //public Rigidbody rb;
    //public int x;
    //public int y;
    //public int z;
    //public Vector4 endPosition (int x, int y, int z)
    //{
    //    this.x = x;
    //    this.y = y;
    //    this.z = z;
    //}
    //public float step;
    //private float progress;
    
       
    public enum StickState
    {
        ChangePosition, Rotate, Push
    }

    public StickState currentStickState;

    // Start is called before the first frame update
    void Start()
    {
        mousePosition3d = new Vector3(0, 0, 0);
        currentStickState = StickState.ChangePosition;
    }

    // Update is called once per frame
    void Update()
    {
        // position = position + new Vector3(1, 0, 0) * Time.deltaTime;       
        //transform.position = position;
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        // Destroy(gameObject);
    }



    void FixedUpdate() {
        if (Input.GetKey(KeyCode.R))
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


        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))//если луч что -то пересекает
        {              
            mousePosition3d = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);
           

            switch (currentStickState)
            {
                case StickState.ChangePosition:
                    transform.position = mousePosition3d;
                    break;
                case StickState.Rotate:
                    transform.LookAt(mousePosition3d);
                    break;
                case StickState.Push:
                    //rb.AddForce(mousePosition3d*acceleration, ForceMode.Impulse);
                    //transform.Translate(mousePosition3d * Time.deltaTime);
                    //transform.Translate(mousePosition3d);
                    //transform.position = Vector3.Lerp(mousePosition3d, endPosition, progress);
                    //progress += step;
                    break;
            }

        }
       
       
           

       
    }


    #region 


    //void FixedUpdate()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        position += new Vector3(1, 2, 3);
    //    }

    //    //if (Input.GetMouseButtonDown(0))
    //    //{
    //    // Debug.Log("Pressed primary button.");             
    //    // position = Input.mousePosition;            
    //    // transform.position = Input.mousePosition;
    //    // Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
    //    // Debug.Log(mousePos);
    //    // Vector3 mousePos2 = Camera.main.ScreenToWorldPoint(mousePos);
    //    // mousePos2.y = 0.102f;
    //    // mousePos2.y = 0.102f;
    //    // transform.position = mousePos2;
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    if (Physics.Raycast(ray, out RaycastHit raycastHit))//если луч что -то пересекает
    //    {
    //        // transform.position = raycastHit.point + new Vector3(0, 0.1f, 0);
    //        transform.position = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);
    //    }


    //    //}
    //}



    // position += new Vector3(1, 0, 0) * 0.02f;
    //1)  position = (0, 15, 0) + (1, 0, 0) * 0.02 = (0, 15, 0) + (0.02, 0, 0) = (0.02, 15, 0) 
    //2)  position = (0.02, 15, 0) + (1, 0, 0) * 0.02 = (0.02, 15, 0) + (0.02, 0, 0) = (0.04, 15, 0) 
    //3)  position = (0.04, 15, 0) + (1, 0, 0) * 0.02 = (0.04, 15, 0) + (0.02, 0, 0) = (0.06, 15, 0) 

    //if (Input.GetButtonDown("Fire1"))
    //{
    //    Debug.Log("Fire1 " + Input.mousePosition);
    //}
    //if (Input.GetMouseButtonDown(1))
    //{
    //    Debug.Log("Pressed secondary button.");
    //}

    //if (Input.GetMouseButtonDown(2))
    //{
    //    Debug.Log("Pressed middle click.");
    //}
    #endregion





}
