using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public double[] DetectArray ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray), "storeResult")]
    public class FaceLandmarkDetector_DetectArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] FaceLandmarkDetector")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector))]
        public HutongGames.PlayMaker.FsmObject
            owner;

        [HutongGames.PlayMaker.ActionSection ("[return] double[](DoubleArray)")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray))]
        public HutongGames.PlayMaker.FsmObject
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            owner = null;
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

            if (!storeResult.IsNone)
            {
                if (!(storeResult.Value is DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray))
                    storeResult.Value = new DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray ();
                ((DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray)storeResult.Value).wrappedObject = wrapped_owner.DetectArray ();
            }
        }

    }

}
