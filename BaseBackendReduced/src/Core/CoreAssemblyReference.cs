using System.Reflection;

namespace BaseBackendReduced.Core;

public static class CoreAssemblyReference
{
    public static Assembly Assembly => typeof(CoreAssemblyReference).Assembly;
}
