using UnityEngine;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{

    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public void Dispose ()")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.DisposableDlibObject), "owner")]
    public class DlibFaceLandmarkDetector_Dispose : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[class] DisposableDlibObject")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ObjectType (typeof (DlibFaceLandmarkDetectorPlayMakerActions.DisposableDlibObject))]
        public HutongGames.PlayMaker.FsmObject
            owner;

        [HutongGames.PlayMaker.ActionSection ("")]
        [Tooltip ("Repeat every frame.")]
        public bool
            everyFrame;

        public override void Reset ()
        {
            owner = null;
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
            if (!(owner.Value is DlibFaceLandmarkDetectorPlayMakerActions.DisposableDlibObject))
            {
                //                LogError ("owner is not initialized. Add Action \"newClassName\".");
                return;
            }
            DlibFaceLandmarkDetectorPlayMakerActions.DisposableDlibObject wrapper = owner.Value as DlibFaceLandmarkDetectorPlayMakerActions.DisposableDlibObject;
            DlibFaceLandmarkDetector.DisposableDlibObject warapped = wrapper.wrappedObject as DlibFaceLandmarkDetector.DisposableDlibObject;

            warapped.Dispose ();
            wrapper.wrappedObject = null;

            Object.Destroy (owner.Value);
            owner.Value = null;

        }

    }

}
