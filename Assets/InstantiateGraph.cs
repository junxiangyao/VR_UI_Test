using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class InstantiateGraph : MonoBehaviour {

	public GameObject surfacePlotGraph;
	VRTK_Pointer pointer;
	GameObject surfacePlotInstance;
	GameObject c;
	


// Use this for initialization
	void Start ()
	{
		// c = GameObject.FindGameObjectWithTag("Controller");
  //   	pointer = c.GetComponent<VRTK_Pointer>();
  //   	Debug.Log("Surface plot instantiated");
	}


    // Update is called once per frame
    void Update()
    {
        /*************************************************
            ray cast control
        **************************************************/
        
        // RaycastHit hit = pointer.pointerRenderer.GetDestinationHit();
        // Debug.Log(hit.point);
        // if (Input.GetMouseButtonDown(0))
        // {
        //     RaycastHit hit = pointer.pointerRenderer.GetDestinationHit();
        //     // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //     Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2, Screen.height/2, 0));

        //     if (Physics.Raycast(ray, out hit))
        //     {
        //         if (hit.collider != null)
        //         {
        //             Debug.Log("Hit!");
        //             hit.transform.gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));

        //         }
        //     }
        // }
    
    }
}