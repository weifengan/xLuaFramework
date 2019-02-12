--Lua控制器的管理器，作用以就是注册所有的控制器
print("启动CtrlManager.lua")

require "xLogic/Common/Define";
require "xLogic/Modules/UIRoot/UIRootCtrl";

CtrlMgr={}

local this=CtrlMgr;

--控制器列表
local ctrlList={};

--初始化 向列表中添加所有控制器
function CtrlMgr.Init()
  ctrlList[CtrlNames.UIRootCtrl]=UIRootCtrl.New();
  return this;
end

--根据控制器名称获取控制器
function CtrlMgr.GetCtrl(ctrlName)
 return ctrlList[ctrlName];
end
