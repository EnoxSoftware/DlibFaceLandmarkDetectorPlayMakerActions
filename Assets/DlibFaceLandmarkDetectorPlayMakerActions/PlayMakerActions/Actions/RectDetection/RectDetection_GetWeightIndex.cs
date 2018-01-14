using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public long GetWeightIndex ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.RectDetection), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Long), "storeResult")]
    public class RectDetection_GetWeightIndex : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] FaceLandmarkDetector")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.RectDetection))]
        public HutongGames.PlayMaker.FsmObject
            owner;



        [HutongGames.PlayMaker.ActionSection ("[return] long(Long)")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Long))]
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

            if (!(owner.Value is DlibFaceLandmarkDetectorPlayMakerActions.RectDetection))
            {
                LogError ("owner is not initialized. Add Action \"newRectDetection\".");
                return;
            }
            DlibFaceLandmarkDetector.FaceLandmarkDetector.RectDetection wrapped_owner = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.RectDetection, DlibFaceLandmarkDetector.FaceLandmarkDetector.RectDetection> (owner);


            if (!(storeResult.Value is DlibFaceLandmarkDetectorPlayMakerActions.Long))
                storeResult.Value = new DlibFaceLandmarkDetectorPlayMakerActions.Long ();
            ((DlibFaceLandmarkDetectorPlayMakerActions.Long)storeResult.Value).wrappedObject = wrapped_owner.weight_index;
        }

    }

}
