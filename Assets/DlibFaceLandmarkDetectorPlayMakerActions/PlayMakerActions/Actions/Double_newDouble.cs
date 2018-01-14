using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public Double newDouble (float value)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmFloat), "value")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double), "storeResult")]
    public class Double_newDouble : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] float")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmFloat))]
        public HutongGames.PlayMaker.FsmFloat
            value;

        [HutongGames.PlayMaker.ActionSection ("[return] Double")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {

            value = 0.0f;
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

            if (!(storeResult.Value is DlibFaceLandmarkDetectorPlayMakerActions.Double))
                storeResult.Value = new DlibFaceLandmarkDetectorPlayMakerActions.Double (0);
            ((DlibFaceLandmarkDetectorPlayMakerActions.Double)storeResult.Value).wrappedObject = (System.Double)value.Value;

        }

    }

}
