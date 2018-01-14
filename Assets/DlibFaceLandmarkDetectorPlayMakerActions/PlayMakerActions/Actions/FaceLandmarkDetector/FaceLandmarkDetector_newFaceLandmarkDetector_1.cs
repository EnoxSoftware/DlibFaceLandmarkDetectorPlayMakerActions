using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;


namespace DlibFaceLandmarkDetectorPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public FaceLandmarkDetector (string objectDetectorFilePath, string shapePredictorFilePath)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "objectDetectorFilePath")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmString), "shapePredictorFilePath")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector), "storeResult")]
    public class FaceLandmarkDetector_newFaceLandmarkDetector_1 : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString
            objectDetectorFilePath;

        [HutongGames.PlayMaker.ActionSection ("[arg2] string")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.ObjectType (typeof (HutongGames.PlayMaker.FsmString))]
        public HutongGames.PlayMaker.FsmString
            shapePredictorFilePath;

        [HutongGames.PlayMaker.ActionSection ("[return] FaceLandmarkDetector")]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector))]
        public HutongGames.PlayMaker.FsmObject
            storeResult;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            objectDetectorFilePath = null;
            shapePredictorFilePath = null;
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

            if (!(storeResult.Value is DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector))
                storeResult.Value = new DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector ();
            ((DlibFaceLandmarkDetectorPlayMakerActions.FaceLandmarkDetector)storeResult.Value).wrappedObject = new DlibFaceLandmarkDetector.FaceLandmarkDetector (objectDetectorFilePath.Value, shapePredictorFilePath.Value);


        }

    }

}
