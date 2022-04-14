using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gato_camina2 : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
    }

	
    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 200*Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);   
        
	if(Input.GetKey("a"))
	    {
	    gameObject.transform.Translate(-1000*Time.deltaTime, 0, 0);
	    }
	else
	    if(Input.GetKey("d"))
	    {
	        gameObject.transform.Translate(1000*Time.deltaTime, 0, 0);
	    }

	if(Input.GetKey("w"))
	    {
	    gameObject.transform.Translate(0, 500*Time.deltaTime, 0);
	    }
	else
	    if(Input.GetKey("s"))
	    {
	        gameObject.transform.Translate(0, -500*Time.deltaTime, 0);
	    }
    }
	
}
 