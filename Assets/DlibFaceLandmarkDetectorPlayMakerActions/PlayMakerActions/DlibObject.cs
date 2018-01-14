using UnityEngine;
using System.Collections;

using DlibFaceLandmarkDetector;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{

    public class DlibObject : UnityEngine.Object
    {

        public System.Object wrappedObject;

        public DlibObject ()
        {

        }

        public DlibObject (System.Object wrappedObject)
        {
            this.wrappedObject = wrappedObject;
        }
    }
}