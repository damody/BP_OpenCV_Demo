/*
*  Copyright (c) 2020-2021 Damody(t1238142000@gmail.com).
*  All rights reserved.
*  @ Date : 2021/05/17
*
*/


using UnrealBuildTool;
using System.Collections.Generic;

public class BP_OpenCV_DemoEditorTarget : TargetRules
{
	public BP_OpenCV_DemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "BP_OpenCV_Demo" } );
	}
}
