/*************************************
			
		LuaMgr 
		
   @desction: Lua环境管理器
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
  
***************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class LuaMgr : MonoSingleton<LuaMgr> {
    //全局的xLua引擎
    public static LuaEnv luaEnv;

	protected override void Awake()
    {
        //实例化xlua引擎
        luaEnv = new LuaEnv();
        //设置xlua脚本 路径 
        luaEnv.DoString(string.Format("package.path='{0}/?.lua'",Application.dataPath));

    }

    public void DoString(string str)
    {
        luaEnv.DoString(str);
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
