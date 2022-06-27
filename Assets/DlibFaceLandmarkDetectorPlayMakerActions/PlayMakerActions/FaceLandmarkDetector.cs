using UnityEngine;
using System.Collections;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    public class FaceLandmarkDetector : DlibFaceLandmarkDetectorPlayMakerActions.DisposableDlibObject
    {

        public FaceLandmarkDetector ()
        {

        }

        public FaceLandmarkDetector (DlibFaceLandmarkDetector.FaceLandmarkDetector nativeObj)
            : base (nativeObj)
        {

        }

    }
}
