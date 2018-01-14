using UnityEngine;
using System.Collections;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{
    public class RectDetection : DlibFaceLandmarkDetectorPlayMakerActions.DlibObject
    {

        public RectDetection ()
        {

        }

        public RectDetection (DlibFaceLandmarkDetector.FaceLandmarkDetector.RectDetection nativeObj)
            : base (nativeObj)
        {

        }

    }
}
