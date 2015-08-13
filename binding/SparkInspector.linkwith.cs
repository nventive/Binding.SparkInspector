using System;
using ObjCRuntime;

[assembly: LinkWith ("SparkInspector.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator64 | LinkTarget.Simulator, ForceLoad = true, Frameworks = "QuartzCore")]
