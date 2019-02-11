/*************************************
			
		Demo 
		
   @desction:
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
  
***************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Demo : MonoBehaviour {

    LuaEnv lua = new LuaEnv();
	// Use this for initialization
	void Start () {
        lua.DoString("print(\"hello\")");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
