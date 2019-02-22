UIRootView={}

local this=UIRootView;

local transform;
local gameObject;


function UIRootView.awake(obj)
   gameObject=obj;
   transform=obj.transform;
   this.InitView();
end

function UIRootView.InitView()
  --找到UI组件
  print("uiroot view ");
  this.btnOpen=transform:Find("btnOpen"):GetComponent("UnityEngine.UI.Button");

  print(this.btnOpen);
end


function UIRootView.start()

end

function UIRootView.update()

end

function UIRootView.ondestroy()

end
