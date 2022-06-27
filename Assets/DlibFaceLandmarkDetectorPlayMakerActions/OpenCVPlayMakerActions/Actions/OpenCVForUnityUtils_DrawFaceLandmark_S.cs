using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;
using OpenCVForUnity;
using OpenCVForUnityPlayMakerActions;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public static void DrawFaceLandmark (Mat imgMat, List<Vector2> points, Scalar color, int thickness)")]
    [HutongGames.PlayMaker.ActionTarget (typeof(OpenCVForUnityPlayMakerActions.Mat), "imgMat")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmArray), "points")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v0")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v1")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v2")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmFloat), "color_v3")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmInt), "thickness")]
    public class OpenCVForUnityUtils_DrawFaceLandmark_S : HutongGames.PlayMaker.FsmStateAction
    {


        [HutongGames.PlayMaker.ActionSection ("[arg1] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            imgMat;

        [HutongGames.PlayMaker.ActionSection ("[arg2] List<Vector2>(Array(Vector2))")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Vector2)]
        public HutongGames.PlayMaker.FsmArray
            points;

        [HutongGames.PlayMaker.ActionSection ("[arg3] Scalar")]

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
            points = null;
            color_v0 = 0.0f;
            color_v1 = 0.0f;
            color_v2 = 0.0f;
            color_v3 = 0.0f;

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


            List<UnityEngine.Vector2> wrapped_points = new List<UnityEngine.Vector2> (points.Length);
            for (int i = 0; i < points.Length; i++) {
                wrapped_points.Add ((Vector2)points.Get (i));

            }


            OpenCVForUnityUtils.DrawFaceLandmark (wrapped_imgMat, wrapped_points, new OpenCVForUnity.CoreModule.Scalar ((double)color_v0.Value, (double)color_v1.Value, (double)color_v2.Value, (double)color_v3.Value), thickness.Value);

        }

    }

}
