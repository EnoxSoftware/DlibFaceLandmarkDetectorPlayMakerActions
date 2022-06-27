using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;
using OpenCVForUnity;
using OpenCVForUnityPlayMakerActions;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public static void SetImage (FaceLandmarkDetector faceLandmarkDetector, Mat imgMat)")]
    [HutongGames.PlayMaker.ActionTarget (typeof(DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector), "faceLandmarkDetector")]
    [HutongGames.PlayMaker.ActionTarget (typeof(OpenCVForUnityPlayMakerActions.Mat), "imgMat")]
    public class OpenCVForUnityUtils_SetImage : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] FaceLandmarkDetector")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof(DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector))]
        public HutongGames.PlayMaker.FsmObject
            faceLandmarkDetector;

        [HutongGames.PlayMaker.ActionSection ("[arg2] Mat")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof(OpenCVForUnityPlayMakerActions.Mat))]
        public HutongGames.PlayMaker.FsmObject
            imgMat;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            faceLandmarkDetector = null;
            imgMat = null;
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

            if (!(faceLandmarkDetector.Value is DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector)) {
                LogError ("faceLandmarkDetector is not initialized. Add Action \"newFaceLandmarkDetector\".");
                return;
            }
            DlibFaceLandmarkDetector.FaceLandmarkDetector wrapped_faceLandmarkDetector = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector, DlibFaceLandmarkDetector.FaceLandmarkDetector> (faceLandmarkDetector);

            if (!(imgMat.Value is OpenCVForUnityPlayMakerActions.Mat)) {
                LogError ("imgMat is not initialized. Add Action \"newMat\".");
                return;
            }
            OpenCVForUnity.CoreModule.Mat wrapped_imgMat = OpenCVForUnityPlayMakerActionsUtils.GetWrappedObject<OpenCVForUnityPlayMakerActions.Mat, OpenCVForUnity.CoreModule.Mat> (imgMat);


            OpenCVForUnityUtils.SetImage (wrapped_faceLandmarkDetector, wrapped_imgMat);

        }

    }

}
