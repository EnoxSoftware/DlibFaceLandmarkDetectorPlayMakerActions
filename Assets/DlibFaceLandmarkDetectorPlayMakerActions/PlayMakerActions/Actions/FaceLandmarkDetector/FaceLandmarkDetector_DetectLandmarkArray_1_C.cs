using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public double[] DetectLandmarkArray (Rect rect)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmRect), "rect")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "storeResult")]
    public class FaceLandmarkDetector_DetectLandmarkArray_1_C : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] FaceLandmarkDetector")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector))]
        public HutongGames.PlayMaker.FsmObject
            owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] Rect")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmRect))]
        public HutongGames.PlayMaker.FsmRect
            rect;

        [HutongGames.PlayMaker.ActionSection ("[return] double[](Array(float))")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            owner = null;
            rect = null;
            storeResult = null;
            everyFrame = false;

        }

        public override void OnEnter ()
        {
            DoProcess ();

            if (!everyFrame)
            {
                Finish ();
            }
        }

        public override void OnUpdate ()
        {
            DoProcess ();
        }

        void DoProcess ()
        {

            if (!(owner.Value is DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector))
            {
                LogError ("owner is not initialized. Add Action \"newFaceLandmarkDetector\".");
                return;
            }
            DlibFaceLandmarkDetector.FaceLandmarkDetector wrapped_owner = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector, DlibFaceLandmarkDetector.FaceLandmarkDetector> (owner);





            double[] casted_storeResult = wrapped_owner.DetectLandmarkArray (rect.Value);

            if (!storeResult.IsNone)
            {
                casted_storeResult.CopyTo (storeResult.floatValues, 0);
            }
        }

    }

}
