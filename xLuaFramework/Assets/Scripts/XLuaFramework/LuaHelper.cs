/*************************************
			
		LuaHelper 
		
   @desction:
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
  
***************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

[LuaCallCSharp]
public class LuaHelper : MonoSingleton<LuaHelper> {

      
    public void LoadUIView(string path, XLuaCustomExport.OnCreate OnCreate=null)
    {
        Transform newui = Instantiate<Transform>(Resources.Load<Transform>("UI/"+ path));

        if (OnCreate != null)
        {
            newui.gameObject.AddComponent<LuaViewBehaviour>();
            OnCreate(newui.gameObject);
        }
    }
}
