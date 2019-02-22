/*************************************
			
		XLuaCustomExport 
		
   @desction:
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
  
***************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public static class XLuaCustomExport  {

    [CSharpCallLua]
    public delegate void OnCreate(GameObject obj);
}
