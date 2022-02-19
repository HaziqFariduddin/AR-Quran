using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Networking;

public class swap : MonoBehaviour
{
	public VirtualButtonBehaviour Vb_swap;	
	public VirtualButtonBehaviour Vb_submit;	
	public GameObject cube;
	public GameObject cube2;
	public Vector3 temPosition;
	public GameObject correct;
	public GameObject incorrect;
	public int checker;

    void Start()
    { //
	correct.SetActive(false);
	incorrect.SetActive(false);
        	Vb_swap.RegisterOnButtonPressed(OnButtonPressed_swap) ;
	Vb_submit.RegisterOnButtonPressed(OnButtonPressed_submit) ;

    }//

  	public void OnButtonPressed_swap(VirtualButtonBehaviour Vb_swap)
	{ //
	correct.SetActive(false);
	incorrect.SetActive(false);
	temPosition= cube.transform.position;
	cube.transform.position = cube2.transform.position;
	cube2.transform.position = temPosition;
	}//	

	public void OnButtonPressed_submit(VirtualButtonBehaviour Vb_submit)
	{//
	Debug.Log("Checking Answr");
	}//	

	void FixedUpdate()
{//
	if(Vb_swap.Pressed==true)
	{
	checker=checker+1;
	}

	if(Vb_submit.Pressed==true)
	{//
	if (checker %2 ==0)
	{//
	incorrect.SetActive(true);
	}//
	else
	{//
	correct.SetActive(true);
	}//
	Debug.Log(checker);
	}//
}

}



