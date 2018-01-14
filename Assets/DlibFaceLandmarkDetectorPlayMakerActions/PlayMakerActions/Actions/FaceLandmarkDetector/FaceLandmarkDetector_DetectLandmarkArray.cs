using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public List<Vector2> DetectLandmark (double left, double top, double width, double height)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector), "owner")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double), "left")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double), "top")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double), "width")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double), "height")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray), "storeResult")]
    public class FaceLandmarkDetector_DetectLandmarkArray : HutongGames.PlayMaker.FsmStateAction
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
            left;

        [HutongGames.PlayMaker.ActionSection ("[arg2] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject
            right;

        [HutongGames.PlayMaker.ActionSection ("[arg3] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject
            width;

        [HutongGames.PlayMaker.ActionSection ("[arg4] double(Double)")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.Double))]
        public HutongGames.PlayMaker.FsmObject
            height;

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
            left = null;
            right = null;
            width = null;
            height = null;
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

            if (!(left.Value is DlibFaceLandmarkDetectorPlayMakerActions.Double))
            {
                LogError ("left is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_left = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.Double, System.Double> (left);
            if (!(right.Value is DlibFaceLandmarkDetectorPlayMakerActions.Double))
            {
                LogError ("right is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_right = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.Double, System.Double> (right);
            if (!(width.Value is DlibFaceLandmarkDetectorPlayMakerActions.Double))
            {
                LogError ("width is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_width = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.Double, System.Double> (width);
            if (!(height.Value is DlibFaceLandmarkDetectorPlayMakerActions.Double))
            {
                LogError ("height is not initialized. Add Action \"newDouble\".");
                return;
            }
            System.Double wrapped_height = DlibFaceLandmarkDetectorPlayMakerActionsUtils.GetWrappedObject<DlibFaceLandmarkDetectorPlayMakerActions.Double, System.Double> (height);



            if (!(storeResult.Value is DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray))
                storeResult.Value = new DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray ();
            ((DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray)storeResult.Value).wrappedObject = wrapped_owner.DetectLandmarkArray (wrapped_left, wrapped_right, wrapped_width, wrapped_height);

        }

    }

}
