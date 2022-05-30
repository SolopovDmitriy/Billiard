using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stick : MonoBehaviour
{
    public Vector3 raycastHitPoint;
    public float speedPush;
    public float pushDelta = 5f;
    public float pushSpeed = 0;
    

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
        //raycastHitPoint = new Vector3(0, 0, 0);
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
            speedPush += 10;
        }

        // position = position + new Vector3(1, 0, 0) * Time.deltaTime;       
        //transform.localPosition= position;
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        // Destroy(gameObject);
        Debug.Log("OnMouseDown");
        //if(currentStickState == StickState.Push)
        //{
        //    GetComponent<Rigidbody>().AddForce(raycastHitPoint * 2, ForceMode.Impulse);
        //}

    }



    void FixedUpdate() {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
        

        if (Physics.Raycast(ray, out RaycastHit raycastHit))//если луч что -то пересекает
        {
            raycastHitPoint = new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);
            
            switch (currentStickState)
            {
                case StickState.ChangePosition:                    
                    transform.position = raycastHitPoint;
                    //Debug.Log("transform.position = " + transform.position);
                    //Debug.Log("transform.localPosition = " + transform.localPosition);

                    break;
                case StickState.Rotate:
                    transform.LookAt(raycastHitPoint);
                    break;
                case StickState.Push:

                    //if (Input.GetMouseButtonDown(0))
                    //{                                              
                    //    transform.localPosition = new Vector3(0, 0, transform.localPosition.z + 0.001f); 
                    //    Debug.Log("Push");
                    //}
                    
                    
                    //pushDelta *= 0.09f;
                    //pushSpeed += pushDelta;
                    //if ((transform.localPosition.z + pushDelta * Time.fixedDeltaTime) > -1)
                    //{
                    //    transform.localPosition = new Vector3(0, 0, (transform.localPosition.z + pushDelta));

                    //    Debug.Log(transform.localPosition);
                    //}
                    //Debug.Log("Push");

                    //transform.localPosition= transform.localPosition- new Vector3(pushDelta * Time.fixedDeltaTime, 0, 0);
                    //transform.localPosition= transform.localPosition- new Vector3(transform.position.x, transform.position.y, transform.position.z + speedPush*Time.fixedDeltaTime);

                    //if (Input.GetMouseButtonDown(0))
                    //{
                    //    Vector3 direction = (raycastHitPoint - transform.position).normalized;
                    //    GetComponent<Rigidbody>().AddForce(direction * 25, ForceMode.Impulse);
                    //    Debug.Log("GetMouseButtonDown");
                    //    //transform.position = raycastHitPoint;

                    //}


                    // rb.AddForce(mousePosition3d*acceleration, ForceMode.Impulse);
                    //transform.Translate(mousePosition3d * Time.deltaTime);
                    //transform.Translate(mousePosition3d);
                    //transform.localPosition= Vector3.Lerp(mousePosition3d, endPosition, progress);
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
    //    // transform.localPosition= Input.mousePosition;
    //    // Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z);
    //    // Debug.Log(mousePos);
    //    // Vector3 mousePos2 = Camera.main.ScreenToWorldPoint(mousePos);
    //    // mousePos2.y = 0.102f;
    //    // mousePos2.y = 0.102f;
    //    // transform.localPosition= mousePos2;
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    if (Physics.Raycast(ray, out RaycastHit raycastHit))//если луч что -то пересекает
    //    {
    //        // transform.localPosition= raycastHit.point + new Vector3(0, 0.1f, 0);
    //        transform.localPosition= new Vector3(raycastHit.point.x, transform.position.y, raycastHit.point.z);
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
