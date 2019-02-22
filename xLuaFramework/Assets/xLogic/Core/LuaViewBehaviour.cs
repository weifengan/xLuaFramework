/*************************************
			
		LuaViewBehaviour 
		
   @desction:
   @author:felixwee
   @email:felixwee@163.com
   @website:www.felixwee.com
  
***************************************/
using System;
using UnityEngine;
using System.Collections;
using XLua;


public class LuaViewBehaviour : MonoBehaviour {

    [CSharpCallLua]
    public delegate void deleLuaAwake(GameObject obj);
    LuaViewBehaviour.deleLuaAwake luaAwake;

    [CSharpCallLua]
    public delegate void deleLuaStart();
    LuaViewBehaviour.deleLuaStart luaStart;

    [CSharpCallLua]
    public delegate void deleLuaUpdate();
    LuaViewBehaviour.deleLuaUpdate luaUpdate;


    [CSharpCallLua]
    public delegate void deleLuaDestroy();
    LuaViewBehaviour.deleLuaDestroy luaOnDestroy;


    private LuaTable scriptEnv;
    private LuaEnv luaEnv;

    public string Tag;
    // Use this for initialization
    void Awake () {
        luaEnv = LuaMgr.luaEnv; //此处从LuaManager获取全局LuaEnv;

        scriptEnv = luaEnv.NewTable();

        LuaTable meta = luaEnv.NewTable();

        meta.Set("__index", luaEnv.Global);
        scriptEnv.SetMetaTable(meta);
        meta.Dispose();


        string prefabName = name;
        if (prefabName.Contains("Clone"))
        {
            prefabName = prefabName.Split(new string[] { "(Clone)" }, StringSplitOptions.RemoveEmptyEntries)[0];
         }

        luaAwake = scriptEnv.GetInPath<LuaViewBehaviour.deleLuaAwake>(prefabName + ".awake");
        luaStart = scriptEnv.GetInPath<LuaViewBehaviour.deleLuaStart>(prefabName + ".start");
        luaUpdate = scriptEnv.GetInPath<LuaViewBehaviour.deleLuaUpdate>(prefabName + ".update");
        luaOnDestroy = scriptEnv.GetInPath<LuaViewBehaviour.deleLuaDestroy>(prefabName + ".ondestroy");

        scriptEnv.Set("self", this);

        if (luaAwake != null)
        {
            luaAwake(gameObject);
        }


    }

    void Start() {
        if(luaStart != null)
        {
            luaStart();
        }

    }


      
    // Update is called once per frame
    void Update () {
        if (luaUpdate != null)
        {
            luaUpdate();
        }
	}

    void OnDestroy()
    {
        if (luaOnDestroy != null)
        {
            luaOnDestroy();
        }

        luaOnDestroy = null;
        luaUpdate = null;
        luaStart = null;
    }
}
