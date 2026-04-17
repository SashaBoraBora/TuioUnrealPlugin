// Fill out your copyright notice in the Description page of Project Settings.

using System.IO;
using UnrealBuildTool;

public class TUIO11 : ModuleRules
{
    public TUIO11(ReadOnlyTargetRules Target) : base(Target)
    {
        Type = ModuleType.External;

        PublicSystemIncludePaths.Add("$(ModuleDir)/TUIO11_CPP");
        PublicSystemIncludePaths.Add("$(ModuleDir)/TUIO11_CPP/oscpack");

        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "binaries/windows_x64/libTUIO.lib"));

            string DllSource = Path.Combine(ModuleDirectory, "binaries/windows_x64/libTUIO.dll");
            RuntimeDependencies.Add("$(ProjectDir)/Binaries/Win64/libTUIO.dll", DllSource);

            PublicDelayLoadDLLs.Add("libTUIO.dll");
        }
        else
        {
            throw new System.Exception("Not implemented for Linux and macOS yet.");
        }
    }
}