namespace MonoTouch.SparkInspector
{
  using System;
  using ObjCRuntime;
  using Foundation;
  
  [BaseType (typeof (NSObject))]
  interface SparkInspector
  {
	
    [Static]
    [Export("enableObservation")]
    void EnableObservation();
  }
}

