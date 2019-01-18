using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;
using OpenCVForUnity;
using OpenCVForUnityPlayMakerActions;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public static void DrawFaceRect (Mat imgMat, UnityEngine.Rect rect, Scalar color, int thickness)")]
    [HutongGames.PlayMaker.ActionTarget (typeof(OpenCVForUnityPlayMakerActions.Mat), "imgMat")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v0")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v1")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v2")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v3")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmRect), "rect")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmInt), "thickness")]
    public class OpenCVForUnityUtils_DrawFaceRect_S : HutongGames.PlayMaker.FsmStateAction
    {


        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            imgMat;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Scalar")]

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat
            color_v0;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat
            color_v1;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat
            color_v2;

        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof(HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat
            color_v3;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Rect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof(HutongGames.PlayMaker.FsmRect))]
        public HutongGames.PlayMaker.FsmRect
            rect;

        [HutongGames.PlayMaker.ActionSection ("[arg4] int")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof(HutongGames.PlayMaker.FsmInt))]
        public HutongGames.PlayMaker.FsmInt
            thickness;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {

            imgMat = null;
            color_v0 = 0.0f;
            color_v1 = 0.0f;
            color_v2 = 0.0f;
            color_v3 = 0.0f;
            rect = null;
            thickness = 0;
            everyFrame = false;

        }

        public override void OnEnter ()
        {
            DoProcess ();

            if (!everyFrame) {
                Finish ();
            }
        }

        public override void OnUpdate ()
        {
            DoProcess ();
        }

        void DoProcess ()
        {


            if (!(imgMat.Value is OpenCVForUnityPlayMakerActions.Mat)) {
                LogError ("imgMat is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_imgMat = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (imgMat);



            OpenCVForUnityUtils.DrawFaceRect (wrapped_imgMat, rect.Value, new OpenCVForUnity.CoreModule.Scalar ((double)color_v0.Value, (double)color_v1.Value, (double)color_v2.Value, (double)color_v3.Value), thickness.Value);

        }

    }

}
