using System;
using System.Reflection.Emit;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace CSharp_Algorithms_n_DataStructures;

public class MyClass
{

    // AllowUnsafeBlock in the .csproj file PropertyGroup
    public unsafe void UsingPointers()
    {
        int *myPtr;
    }
}

public class HackingCSharp
{
    public static void RunThisHack()
    {
        Base b = new Derived_2();
        b.Foo(123);
        InvokeMethod<Derived>(() => b.Foo(123 + 456));
    }

    // private static Action GetLambda(object a)
    // {
    //     throw new NotImplementedException();
    // }
    public static void InvokeMethod<T>(Expression<Action> caller) where T : class{
        if(caller.Body.NodeType != ExpressionType.Call)
        {
            throw new ArgumentException("Parameter must call a method", "caller");
        }

        // var castedExpression = (MethodCallExpression)caller.Body;
        // var evaluatedArguments = castedExpression.Arguments.Select(a => GetLambda(a).Invoke()).ToArray();
        // var methodToCall = typeof(T).GetMethod(castedExpression.Method.Name, evaluatedArguments.Select(a => a.GetType()).ToArray());
        // var methodInvoker = GetCaller<T>(castedExpression, methodToCall);
        // methodInvoker.Invoke((T)GetLambda(castedExpression.Object).Invoke(), evaluatedArguments);
    }

    
    public static Action<T, object[]> GetCaller<T>(MethodCallExpression expression, MethodInfo methodToCall)
    {
        
        var helperMethod = new DynamicMethod(
            string.Empty,
            typeof(void),
            new[] { typeof(T), typeof(object[]) },
            typeof(T).Module,
            true
        );
        var ilGenerator = helperMethod.GetILGenerator();
        ilGenerator.Emit(OpCodes.Ldarg_0);
        for(int i = 0; i < expression.Arguments.Count(); ++i)
        {
            var argumentType = expression.Arguments[i].Type;
            ilGenerator.Emit(OpCodes.Ldarg_1);
            ilGenerator.Emit(OpCodes.Ldc_I4, i);
            ilGenerator.Emit(OpCodes.Ldelem, typeof(object));
            if (argumentType.IsValueType){
                ilGenerator.Emit(OpCodes.Unbox_Any, argumentType);
            }
        }

        ilGenerator.Emit(OpCodes.Call, methodToCall);
        ilGenerator.Emit(OpCodes.Ret);
        var methodInvoker = (Action<T, object[]>)helperMethod.CreateDelegate(typeof(Action<T, object[]>));
        return methodInvoker;
    }

}
public class Base{
    public virtual void Foo(int dummyParameter){
        Console.WriteLine($"Base: {dummyParameter}");
    }
}
public class Derived: Base{
    public override void Foo(int dummyParameter){
        Console.WriteLine($"Derived: {dummyParameter}");
    }
}
public class Derived_2: Derived{
    public override void Foo(int dummyParameter){
        Console.WriteLine($"Derived_2: {dummyParameter}");
    }
}