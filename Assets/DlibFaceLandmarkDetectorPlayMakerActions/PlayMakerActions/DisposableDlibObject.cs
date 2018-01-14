using UnityEngine;
using System.Collections;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{

    public class DisposableDlibObject : DlibObject
    {

        public DisposableDlibObject ()
        {

        }

        public DisposableDlibObject (DlibFaceLandmarkDetector.DisposableDlibObject nativeObj)
            : base (nativeObj)
        {

        }
    }
}