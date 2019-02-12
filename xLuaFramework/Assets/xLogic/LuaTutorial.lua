function TestNumber(n)
  return n*10;
end


function TestString(n)
  --return n..'abc'; //字符串连接
  --return string.len(n) --获取长度
  --return #n;  --字符串长度
  --return string.upper(n) --转换大写
  --return string.lower(n) --转换小写
  --return string.find(n,'a') --查找
  --return string.format("测试%s",n); --格式化
  return string.rep(n,3);
 end

function TestIf(n)
   local retValue="等于3";
   if(n<3) then
     retValue="小于3";
   elseif(n>3)then
     retValue="大于3";
   end
   return retValue;
end


function TestDoloop(n)
  --i=1,i<=10
  for i=1,n,1 do
    print (i);
  end
end

function TestArr()
  local arr={"abc","123","张三"}
  --数组下标从1开始
  for i=1,#arr,1 do
    print (arr[i]);
  end
  print('-------------------');

  --foreach key相当索引 v 为值
  for key,v in ipairs(arr) do
     print(key..v);
  end
end

function TestTable()
  local mytable={};
  mytable[#mytable+1]="你好";
  mytable[#mytable+1]="测试";
  mytable[#mytable+1]="欢迎您lua";

  --mytable[1]=nil; --只是把数据设置为nil
  table.remove(mytable,2);

  table.insert(mytable,1,"我来了");
  --数组转字符串
  print(table.concat(mytable,"|"));

  mytable.x="我是定义的x";
  mytable.y="我是定义的y";

  print(mytable.x);
  print(#mytable);
end

print('欢迎进入lua world!');
print ('得到的值='..TestNumber(2.5));
  print('-------------------');
print ('得到的值='..TestString("你好abc"));
  print('-------------------');
print ('得到的值='..TestIf(6));
  print('-------------------');
TestDoloop(10);
  print('-------------------');
TestArr();
  print('-------------------');
TestTable();
