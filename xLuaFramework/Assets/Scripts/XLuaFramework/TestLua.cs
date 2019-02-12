/*************************************
			
		TestLua 
		
   @desction:
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
  
***************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLua : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LuaHelper.Instance.LoadUIView("UIRootView");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
