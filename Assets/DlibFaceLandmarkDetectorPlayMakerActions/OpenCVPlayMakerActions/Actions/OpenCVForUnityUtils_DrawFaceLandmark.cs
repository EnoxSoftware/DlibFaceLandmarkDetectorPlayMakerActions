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
    [HutongGames.PlayMaker.ActionTarget (typeof(OpenCVForUnityPlayMakerActions.Scalar), "color")]
    [HutongGames.PlayMaker.ActionTarget (typeof(HutongGames.PlayMaker.FsmInt), "thickness")]
    public class OpenCVForUnityUtils_DrawFaceLandmark : HutongGames.PlayMaker.FsmStateAction
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
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof(OpenCVForUnityPlayMakerActions.Scalar))]
        public HutongGames.PlayMaker.FsmObject
            color;



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
            color = null;

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

            if (!(color.Value is OpenCVForUnityPlayMakerActions.Scalar)) {
                LogError ("color is not initialized. Add Action \"newScalar\".");
                return;
            }
            OpenCVForUnity.CoreModule.Scalar wrapped_color = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Scalar, OpenCVForUnity.CoreModule.Scalar> (color);

            List<UnityEngine.Vector2> wrapped_points = new List<UnityEngine.Vector2> (points.Length);
            for (int i = 0; i < points.Length; i++) {
                wrapped_points.Add ((Vector2)points.Get (i));

            }


            OpenCVForUnityUtils.DrawFaceLandmark (wrapped_imgMat, wrapped_points, wrapped_color, thickness.Value);

        }

    }

}
