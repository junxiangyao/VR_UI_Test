using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MiniMap : MonoBehaviour
{
	VRTK_Pointer pointer;
	GameObject left_controller;
	GameObject right_controller;
	GameObject play_area;

	float rotation_counter;
	float yRotation = 0.0f;
	float dist_mini = 0.0f;
	float angle_sin = 0.0f;
	float angle_cos = 0.0f;
	float dist_real = 0.0f;

	
	VRTK_BasicTeleport teleporter;

    // Start is called before the first frame update
    void Start()
    {
		right_controller = GameObject.FindGameObjectWithTag("ControllerRight");
		left_controller = GameObject.FindGameObjectWithTag("ControllerLeft");
    	pointer = right_controller.GetComponent<VRTK_Pointer>();
    	play_area = GameObject.FindGameObjectWithTag("Teleport");
        teleporter = play_area.GetComponent<VRTK_BasicTeleport>(); 
    }

    // Update is called once per frame
    void Update()
    {
    	transform.localPosition = new Vector3(left_controller.transform.position.x,
    		left_controller.transform.position.y,
    		left_controller.transform.position.z);
    	            			Debug.Log(teleporter);
    	// Debug.Log(right_controller.GetComponent<VRTK_ControllerEvents>().triggerTouched);

 		if (left_controller.GetComponent<VRTK_ControllerEvents>().gripPressed)
        {
        	yRotation += 5.0f;
        	transform.eulerAngles = new Vector3(0, yRotation, 0);
        }


        if (right_controller.GetComponent<VRTK_ControllerEvents>().triggerTouched)
        {
        	RaycastHit hit = pointer.pointerRenderer.GetDestinationHit();
        	Debug.Log(hit.point);
            if (right_controller.GetComponent<VRTK_ControllerEvents>().triggerPressed)
            {
            	if(hit.transform.gameObject.CompareTag("MiniMap"))
            	{
            		dist_mini = Vector3.Distance(transform.localPosition, hit.point);
            		if(dist_mini <= 0.3f)
            		{
            			angle_sin = hit.point.x - transform.localPosition.x;
            			angle_cos = hit.point.z - transform.localPosition.z;
            			


            			// teleporter.ForceTeleport(
            			// new Vector3(Mathf.Sin(angle_sin * 3.1415926535f / 180f) * dist_mini * 100,
            			// 0f,
            			// Mathf.Cos(angle_cos  * 3.1415926535f / 180f) * dist_mini * 100), Quaternion.Euler(0, 0, 0));
            			teleporter.ForceTeleport(new Vector3(0,0,0),Quaternion.Euler(new Vector3(0, 0, 0)));
            		}
            	}
            	
            //     if (hit.collider != null)
            //     {
            //         Debug.Log("Hit!");
            //         hit.transform.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));

            	// }
            }
        }
    }
}
