using System;
using UnityEngine;
using UnityEditor;
using HutongGames.PlayMakerEditor;
using Object = UnityEngine.Object;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{

    // Test with action that uses an FsmObject variable of AudioClip type. E.g., Set Audio Clip

    [ObjectPropertyDrawer (typeof (DlibFaceLandmarkDetectorPlayMakerActions.RectDetection))]
    public class RectDetectionObjectPropertyDrawer : DlibObjectPropertyDrawer
    {

    }
}
