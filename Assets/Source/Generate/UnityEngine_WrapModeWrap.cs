﻿using System;
using LuaInterface;

public class UnityEngine_WrapModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.WrapMode));
		L.RegVar("Once", get_Once, null);
		L.RegVar("Loop", get_Loop, null);
		L.RegVar("PingPong", get_PingPong, null);
		L.RegVar("Default", get_Default, null);
		L.RegVar("ClampForever", get_ClampForever, null);
		L.RegVar("Clamp", get_Clamp, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Once(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Once);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Loop(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Loop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_PingPong(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.PingPong);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Default(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Default);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ClampForever(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.ClampForever);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Clamp(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.WrapMode.Clamp);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.WrapMode o = (UnityEngine.WrapMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}
