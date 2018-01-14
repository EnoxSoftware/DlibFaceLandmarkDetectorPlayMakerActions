using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public List<Rect> Detect (double adjust_threshold)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double), "adjust_threshold")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "storeResult")]
    public class FaceLandmarkDetector_Detect_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] FaceLandmarkDetector")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector))]
        public HutongGames.PlayMaker.FsmObject
            owner;

        [HutongGames.PlayMaker.ActionSection ("[arg1] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject
            adjust_threshold;

        [HutongGames.PlayMaker.ActionSection ("[return] List<Rect>(Array(Rect))")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        //		[HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Rect)]
        public HutongGames.PlayMaker.FsmArray
            storeResult;
        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            owner = null;
            adjust_threshold = null;
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

            if (!(adjust_threshold.Value is DlibFaceLandmarkDetectorPlayMakerActions.Double))
            {
                LogError ("adjust_threshold is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_adjust_threshold = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.Double, System.Double> (adjust_threshold);


            List<UnityEngine.Rect> wrapped_storeResult = wrapped_owner.Detect (wrapped_adjust_threshold);

            if (!storeResult.IsNone)
            {

                if (storeResult.Length != wrapped_storeResult.Count)
                {
                    storeResult.Resize (wrapped_storeResult.Count);
                }
                for (int i = 0; i < wrapped_storeResult.Count; i++)
                {
                    storeResult.Set (i, wrapped_storeResult[i]);
                }
            }

        }

    }

}
