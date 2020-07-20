## Variables and Data type
- python is implicit typing(隐式输入)
- csharp is explicit typing(显式输入)

python 中一个变量的类型是可变的，dynamic typing（动态的）；csharp中一旦定义，就不可变，static typing（静态的）

## 几何数据类型

```c#
Point3d A = new Point3d();//声明新的变量，变量类型为Point3d（point_3d_double),括号中没有参数标识此时生成坐标为0的点
Point3d B = new Point3d(0.0,1.0,2.0);
Point3d C = B;//C是一个独立分开的副本
```

## if条件判断
```c#
if (a>b)
{
    Print();
}
else
{
    Print();
}
```

## for循环
```c#
for (int i = 0; i <5 ; i++)
{
    Print(i.ToString());//ToString或者Convert.toString与convert.ToInt16等都是用来转换输出的
}
```

## foreach循环
```c#
foreach (Point3d point in points)
{
    //do something with "point">
}
```

## RhinoApp.WriteLine("Hello world");

## List
```c#
List<double> myNumbers = new List<double>(){0.5,3.14};//变量类型是List<double>,变量名myNumbers，大括号来进行初始化
myNumbers.Add(1.23);
myNumbers.Add(2.35);

Print(myNumbers[0].ToString());
```

### example

```c#
List<Point3d> myPoints = new List<Point3d>();

for(int i = 0;i < 100;i++)
{
    Point3d point = new Point3d(i, i, i);
    myPoints.Add(point);
}

A = myPoints;

List<Point3d> myPoints = new List<Point3d>();

for(int i = 0;i < 100;i++)
{
    for(int j = 0;j < 100;j++)
    {
        myPoints.Add(new Point3d(i, j, 0));
    }
}

A = myPoints;
```

