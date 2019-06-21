using System;
using System.Collections.Generic;
using System.Reflection;

namespace YoutubeApiTests.Methods
{
	public static class ReflectionMethods
	{
		public const BindingFlags Flags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

		public static void SetTo<T>(T value, T newValue) where T : class
		{
			Type typeFromHandle = typeof(T);
			HashSet<FieldInfo> hashSet = new HashSet<FieldInfo>();
			foreach (FieldInfo runtimeField in typeFromHandle.GetRuntimeFields())
			{
				if (!runtimeField.IsStatic)
				{
					runtimeField.SetValue(value, runtimeField.GetValue(newValue));
					hashSet.Add(runtimeField);
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			foreach (FieldInfo fieldInfo in fields)
			{
				if (!hashSet.Contains(fieldInfo))
				{
					fieldInfo.SetValue(value, fieldInfo.GetValue(newValue));
				}
			}
		}
	}
}
