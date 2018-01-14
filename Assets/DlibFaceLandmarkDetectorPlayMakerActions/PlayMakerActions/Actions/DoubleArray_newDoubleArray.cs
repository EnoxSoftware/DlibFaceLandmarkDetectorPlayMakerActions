using UnityEngine;
using System.Collections.Generic;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    [HutongGames.PlayMaker.ActionCategory ("DlibFaceLandmarkDetector")]
    [HutongGames.PlayMaker.Tooltip ("public DoubleArray newDoubleArray (float[] array)")]
    [HutongGames.PlayMaker.ActionTarget (typeof (HutongGames.PlayMaker.FsmArray), "array")]
    [HutongGames.PlayMaker.ActionTarget (typeof (DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray), "storeResult")]
    public class DoubleArray_newDoubleArray : HutongGames.PlayMaker.FsmStateAction
    {

        [HutongGames.PlayMaker.ActionSection ("[arg1] float[](Array(float))")]
        [HutongGames.PlayMaker.RequiredField]
        [HutongGames.PlayMaker.UIHint (HutongGames.PlayMaker.UIHint.Variable)]
        [HutongGames.PlayMaker.ArrayEditor (HutongGames.PlayMaker.VariableType.Float)]
        public HutongGames.PlayMaker.FsmArray
            array;

        [HutongGames.PlayMaker.ActionSection ("[return] DoubleArray")]
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

            array = null;
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
            float[] float_array = array.floatValues;
            double[] casted_array = new double[float_array.Length];
            //            for (int i = 0; i < casted_array.Length; i++) {
            //                casted_array [i] = (double)float_array [i];
            //            }
            float_array.CopyTo (casted_array, 0);

            if (!(storeResult.Value is DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray))
                storeResult.Value = new DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray (new System.Double[0]);
            ((DlibFaceLandmarkDetectorPlayMakerActions.DoubleArray)storeResult.Value).wrappedObject = casted_array;

        }

    }

}
