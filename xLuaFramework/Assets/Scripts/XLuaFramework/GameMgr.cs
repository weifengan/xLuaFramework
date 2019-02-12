/*************************************
			
		GameManager 
		
   @desction:
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
  
***************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour {

    void Awake()
    {
        gameObject.AddComponent<LuaMgr>();

    }
	// Use this for initialization
	void Start () {
        LuaMgr.Instance.DoString("require 'xLogic/Main'");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
