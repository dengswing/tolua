﻿using System;
using LuaInterface;

public class UnityEngine_ApplicationWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("Application");
		L.RegFunction("Quit", Quit);
		L.RegFunction("CancelQuit", CancelQuit);
		L.RegFunction("LoadLevel", LoadLevel);
		L.RegFunction("LoadLevelAsync", LoadLevelAsync);
		L.RegFunction("LoadLevelAdditiveAsync", LoadLevelAdditiveAsync);
		L.RegFunction("UnloadLevel", UnloadLevel);
		L.RegFunction("LoadLevelAdditive", LoadLevelAdditive);
		L.RegFunction("GetStreamProgressForLevel", GetStreamProgressForLevel);
		L.RegFunction("CanStreamedLevelBeLoaded", CanStreamedLevelBeLoaded);
		L.RegFunction("CaptureScreenshot", CaptureScreenshot);
		L.RegFunction("HasProLicense", HasProLicense);
		L.RegFunction("ExternalCall", ExternalCall);
		L.RegFunction("OpenURL", OpenURL);
		L.RegFunction("RequestUserAuthorization", RequestUserAuthorization);
		L.RegFunction("HasUserAuthorization", HasUserAuthorization);
		L.RegVar("loadedLevel", get_loadedLevel, null);
		L.RegVar("loadedLevelName", get_loadedLevelName, null);
		L.RegVar("levelCount", get_levelCount, null);
		L.RegVar("streamedBytes", get_streamedBytes, null);
		L.RegVar("isPlaying", get_isPlaying, null);
		L.RegVar("isEditor", get_isEditor, null);
		L.RegVar("isWebPlayer", get_isWebPlayer, null);
		L.RegVar("platform", get_platform, null);
		L.RegVar("isMobilePlatform", get_isMobilePlatform, null);
		L.RegVar("isConsolePlatform", get_isConsolePlatform, null);
		L.RegVar("runInBackground", get_runInBackground, set_runInBackground);
		L.RegVar("dataPath", get_dataPath, null);
		L.RegVar("streamingAssetsPath", get_streamingAssetsPath, null);
		L.RegVar("persistentDataPath", get_persistentDataPath, null);
		L.RegVar("temporaryCachePath", get_temporaryCachePath, null);
		L.RegVar("srcValue", get_srcValue, null);
		L.RegVar("absoluteURL", get_absoluteURL, null);
		L.RegVar("unityVersion", get_unityVersion, null);
		L.RegVar("version", get_version, null);
		L.RegVar("bundleIdentifier", get_bundleIdentifier, null);
		L.RegVar("installMode", get_installMode, null);
		L.RegVar("sandboxType", get_sandboxType, null);
		L.RegVar("productName", get_productName, null);
		L.RegVar("companyName", get_companyName, null);
		L.RegVar("cloudProjectId", get_cloudProjectId, null);
		L.RegVar("webSecurityEnabled", get_webSecurityEnabled, null);
		L.RegVar("webSecurityHostUrl", get_webSecurityHostUrl, null);
		L.RegVar("targetFrameRate", get_targetFrameRate, set_targetFrameRate);
		L.RegVar("systemLanguage", get_systemLanguage, null);
		L.RegVar("stackTraceLogType", get_stackTraceLogType, set_stackTraceLogType);
		L.RegVar("backgroundLoadingPriority", get_backgroundLoadingPriority, set_backgroundLoadingPriority);
		L.RegVar("internetReachability", get_internetReachability, null);
		L.RegVar("genuine", get_genuine, null);
		L.RegVar("genuineCheckAvailable", get_genuineCheckAvailable, null);
		L.RegVar("isShowingSplashScreen", get_isShowingSplashScreen, null);
		L.RegVar("logMessageReceived", get_logMessageReceived, set_logMessageReceived);
		L.RegVar("logMessageReceivedThreaded", get_logMessageReceivedThreaded, set_logMessageReceivedThreaded);
		L.RegFunction("LogCallback", LogCallback);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Quit(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);

		try
		{
			UnityEngine.Application.Quit();
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CancelQuit(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);

		try
		{
			UnityEngine.Application.CancelQuit();
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadLevel(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);

			try
			{
				UnityEngine.Application.LoadLevel(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			return 0;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);

			try
			{
				UnityEngine.Application.LoadLevel(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.LoadLevel");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadLevelAsync(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);
			UnityEngine.AsyncOperation o = null;

			try
			{
				o = UnityEngine.Application.LoadLevelAsync(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			ToLua.PushObject(L, o);
			return 1;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			UnityEngine.AsyncOperation o = null;

			try
			{
				o = UnityEngine.Application.LoadLevelAsync(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			ToLua.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.LoadLevelAsync");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadLevelAdditiveAsync(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);
			UnityEngine.AsyncOperation o = null;

			try
			{
				o = UnityEngine.Application.LoadLevelAdditiveAsync(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			ToLua.PushObject(L, o);
			return 1;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			UnityEngine.AsyncOperation o = null;

			try
			{
				o = UnityEngine.Application.LoadLevelAdditiveAsync(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			ToLua.PushObject(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.LoadLevelAdditiveAsync");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadLevel(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);
			bool o;

			try
			{
				o = UnityEngine.Application.UnloadLevel(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			bool o;

			try
			{
				o = UnityEngine.Application.UnloadLevel(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.UnloadLevel");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadLevelAdditive(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);

			try
			{
				UnityEngine.Application.LoadLevelAdditive(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			return 0;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);

			try
			{
				UnityEngine.Application.LoadLevelAdditive(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.LoadLevelAdditive");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStreamProgressForLevel(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);
			float o;

			try
			{
				o = UnityEngine.Application.GetStreamProgressForLevel(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			float o;

			try
			{
				o = UnityEngine.Application.GetStreamProgressForLevel(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.GetStreamProgressForLevel");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanStreamedLevelBeLoaded(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);
			bool o;

			try
			{
				o = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else if (count == 1 && ToLua.CheckTypes(L, 1, typeof(int)))
		{
			int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
			bool o;

			try
			{
				o = UnityEngine.Application.CanStreamedLevelBeLoaded(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.CanStreamedLevelBeLoaded");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CaptureScreenshot(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);

		if (count == 1 && ToLua.CheckTypes(L, 1, typeof(string)))
		{
			string arg0 = ToLua.ToString(L, 1);

			try
			{
				UnityEngine.Application.CaptureScreenshot(arg0);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			return 0;
		}
		else if (count == 2 && ToLua.CheckTypes(L, 1, typeof(string), typeof(int)))
		{
			string arg0 = ToLua.ToString(L, 1);
			int arg1 = (int)LuaDLL.lua_tonumber(L, 2);

			try
			{
				UnityEngine.Application.CaptureScreenshot(arg0, arg1);
			}
			catch(Exception e)
			{
				return LuaDLL.toluaL_exception(L, e);
			}

			return 0;
		}
		else
		{
			LuaDLL.luaL_error(L, "invalid arguments to method: UnityEngine.Application.CaptureScreenshot");
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasProLicense(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 0);
		bool o;

		try
		{
			o = UnityEngine.Application.HasProLicense();
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ExternalCall(IntPtr L)
	{
		int count = LuaDLL.lua_gettop(L);
		string arg0 = ToLua.CheckString(L, 1);
		object[] arg1 = ToLua.ToParamsObject(L, 2, count - 1);

		try
		{
			UnityEngine.Application.ExternalCall(arg0, arg1);
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OpenURL(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		string arg0 = ToLua.CheckString(L, 1);

		try
		{
			UnityEngine.Application.OpenURL(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RequestUserAuthorization(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)ToLua.CheckObject(L, 1, typeof(UnityEngine.UserAuthorization));
		UnityEngine.AsyncOperation o = null;

		try
		{
			o = UnityEngine.Application.RequestUserAuthorization(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}

		ToLua.PushObject(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasUserAuthorization(IntPtr L)
	{
		ToLua.CheckArgsCount(L, 1);
		UnityEngine.UserAuthorization arg0 = (UnityEngine.UserAuthorization)ToLua.CheckObject(L, 1, typeof(UnityEngine.UserAuthorization));
		bool o;

		try
		{
			o = UnityEngine.Application.HasUserAuthorization(arg0);
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}

		LuaDLL.lua_pushboolean(L, o);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadedLevel(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Application.loadedLevel);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_loadedLevelName(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.loadedLevelName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_levelCount(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Application.levelCount);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamedBytes(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Application.streamedBytes);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPlaying(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.isPlaying);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isEditor(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.isEditor);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isWebPlayer(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.isWebPlayer);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_platform(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Application.platform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isMobilePlatform(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.isMobilePlatform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isConsolePlatform(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.isConsolePlatform);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_runInBackground(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.runInBackground);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dataPath(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.dataPath);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_streamingAssetsPath(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.streamingAssetsPath);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_persistentDataPath(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.persistentDataPath);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_temporaryCachePath(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.temporaryCachePath);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_srcValue(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.srcValue);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_absoluteURL(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.absoluteURL);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_unityVersion(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.unityVersion);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_version(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.version);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bundleIdentifier(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.bundleIdentifier);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_installMode(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Application.installMode);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sandboxType(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Application.sandboxType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_productName(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.productName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_companyName(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.companyName);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cloudProjectId(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.cloudProjectId);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_webSecurityEnabled(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.webSecurityEnabled);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_webSecurityHostUrl(IntPtr L)
	{
		LuaDLL.lua_pushstring(L, UnityEngine.Application.webSecurityHostUrl);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_targetFrameRate(IntPtr L)
	{
		LuaDLL.lua_pushinteger(L, UnityEngine.Application.targetFrameRate);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_systemLanguage(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Application.systemLanguage);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_stackTraceLogType(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Application.stackTraceLogType);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_backgroundLoadingPriority(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Application.backgroundLoadingPriority);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_internetReachability(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.Application.internetReachability);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_genuine(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.genuine);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_genuineCheckAvailable(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.genuineCheckAvailable);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isShowingSplashScreen(IntPtr L)
	{
		LuaDLL.lua_pushboolean(L, UnityEngine.Application.isShowingSplashScreen);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logMessageReceived(IntPtr L)
	{
		ToLua.Push(L, new EventObject("UnityEngine.Application.logMessageReceived"));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logMessageReceivedThreaded(IntPtr L)
	{
		ToLua.Push(L, new EventObject("UnityEngine.Application.logMessageReceivedThreaded"));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_runInBackground(IntPtr L)
	{
		bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
		UnityEngine.Application.runInBackground = arg0;
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_targetFrameRate(IntPtr L)
	{
		int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
		UnityEngine.Application.targetFrameRate = arg0;
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_stackTraceLogType(IntPtr L)
	{
		UnityEngine.StackTraceLogType arg0 = (UnityEngine.StackTraceLogType)ToLua.CheckObject(L, 2, typeof(UnityEngine.StackTraceLogType));
		UnityEngine.Application.stackTraceLogType = arg0;
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_backgroundLoadingPriority(IntPtr L)
	{
		UnityEngine.ThreadPriority arg0 = (UnityEngine.ThreadPriority)ToLua.CheckObject(L, 2, typeof(UnityEngine.ThreadPriority));
		UnityEngine.Application.backgroundLoadingPriority = arg0;
		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logMessageReceived(IntPtr L)
	{
		EventObject arg0 = null;

		if (LuaDLL.lua_isuserdata(L, 2) != 0)
		{
			arg0 = (EventObject)ToLua.ToObject(L, 2);
		}
		else
		{
			return LuaDLL.luaL_error(L, "The event 'UnityEngine.Application.logMessageReceived' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
		}

		if (arg0.op == EventOp.Add)
		{
			UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)DelegateFactory.CreateDelegate(L, typeof(UnityEngine.Application.LogCallback), arg0.func);
			UnityEngine.Application.logMessageReceived += ev;
		}
		else if (arg0.op == EventOp.Sub)
		{
			UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)LuaMisc.GetEventHandler(null, typeof(UnityEngine.Application), "logMessageReceived");
			Delegate[] ds = ev.GetInvocationList();

			for (int i = 0; i < ds.Length; i++)
			{
				ev = (UnityEngine.Application.LogCallback)ds[i];
				LuaDelegate ld = ev.Target as LuaDelegate;

				if (ld != null && ld.func == arg0.func)
				{
					UnityEngine.Application.logMessageReceived -= ev;
					ld.func.Dispose();
					break;
				}
			}

			arg0.func.Dispose();
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logMessageReceivedThreaded(IntPtr L)
	{
		EventObject arg0 = null;

		if (LuaDLL.lua_isuserdata(L, 2) != 0)
		{
			arg0 = (EventObject)ToLua.ToObject(L, 2);
		}
		else
		{
			return LuaDLL.luaL_error(L, "The event 'UnityEngine.Application.logMessageReceivedThreaded' can only appear on the left hand side of += or -= when used outside of the type 'UnityEngine.Application'");
		}

		if (arg0.op == EventOp.Add)
		{
			UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)DelegateFactory.CreateDelegate(L, typeof(UnityEngine.Application.LogCallback), arg0.func);
			UnityEngine.Application.logMessageReceivedThreaded += ev;
		}
		else if (arg0.op == EventOp.Sub)
		{
			UnityEngine.Application.LogCallback ev = (UnityEngine.Application.LogCallback)LuaMisc.GetEventHandler(null, typeof(UnityEngine.Application), "logMessageReceivedThreaded");
			Delegate[] ds = ev.GetInvocationList();

			for (int i = 0; i < ds.Length; i++)
			{
				ev = (UnityEngine.Application.LogCallback)ds[i];
				LuaDelegate ld = ev.Target as LuaDelegate;

				if (ld != null && ld.func == arg0.func)
				{
					UnityEngine.Application.logMessageReceivedThreaded -= ev;
					ld.func.Dispose();
					break;
				}
			}

			arg0.func.Dispose();
		}

		return 0;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogCallback(IntPtr L)
	{
		LuaFunction func = ToLua.CheckLuaFunction(L, 1);
		Delegate arg1 = DelegateFactory.CreateDelegate(L, typeof(UnityEngine.Application.LogCallback), func);
		ToLua.Push(L, arg1);
		return 1;
	}
}

