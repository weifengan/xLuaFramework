print("加载UIRootCtrl");
UIRootCtrl={};

local this=UIRootCtrl;

local root;
local transform;
local GameObject;

function UIRootCtrl.New()
  return this;
end

function UIRootCtrl.Awake()
  print("主界面启动了");
  --这里就是负责把UI克隆出来
   CS.LuaHelper.Instance:LoadUIView("UIRootView");
end

--启动事件
function UIRootCtrl.OnCreate()
  print("进入回调OnCreate");

  btnOpen=UIRootView.btnOpenMessage:GetComponent('UnityEngine.UI.Button');
  --btnOpen.onClick:AddListener(this.OpenMessageClick);
end

--单击事件
function UIRootCtrl.OpenMessageClick()
  print("点击了打开消息按钮");

end
