print('启动GameInit.lua')

require "xLogic/CtrlMgr";

GameInit={};

local this=GameInit;

function GameInit.Init()
  print("初始化GameInit");
  this.InitViews();
  CtrlMgr.Init();
  GameInit.LoadView(CtrlNames.UIRootCtrl);
end


function GameInit.InitViews()
   for i=1,#ViewNames do
        require ('xLogic/Modules/UIRoot/'..tostring(ViewNames[i]));
   end
end

function GameInit.LoadView(type)
  local ctrl=CtrlMgr.GetCtrl(type);
  if ctrl~=nil then
    ctrl.Awake();
  end
end
