using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public float getValue ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "storeResult")]
    public class Double_getValue : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] Double")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject
            owner;

        [HutongGames.PlayMaker.ActionSection ("[return] float")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat
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

            if (!(owner.Value is DlibFaceLandmarkDetectorPlayMakerActions.Double))
                owner.Value = new DlibFaceLandmarkDetectorPlayMakerActions.Double (0);

            System.Double wrapped_owner = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.Double, System.Double> (owner);
            storeResult.Value = (float)wrapped_owner;

        }

    }

}
