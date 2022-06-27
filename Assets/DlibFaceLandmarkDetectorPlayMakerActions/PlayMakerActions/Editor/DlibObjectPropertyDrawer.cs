using System;
using UnityEngine;
using UnityEditor;
using HutongGames.PlayMakerEditor;
using Object = UnityEngine.Object;

//using DlibFaceLandmarkDetectorPlayMakerActions;

namespace DlibFaceLandmarkDetectorPlayMakerActions
{

    // Test with action that uses an FsmObject variable of AudioClip type. E.g., Set Audio Clip
    [ObjectPropertyDrawer (typeof (DlibFaceLandmarkDetectorPlayMakerActions.DlibObject))]
    public class DlibObjectPropertyDrawer : ObjectPropertyDrawer
    {
        public override Object OnGUI (GUIContent label, Object obj, bool isSceneObject, params object[] attributes)
        {

            if (obj is DlibObject)
            {
                GUILayout.BeginVertical ();


                EditorGUILayout.LabelField (label);

                EditorGUI.indentLevel++;

                DlibObject opencvObject = obj as DlibObject;

                if (opencvObject.wrappedObject != null)
                {
                    EditorGUILayout.SelectableLabel (opencvObject.wrappedObject.ToString ());
                }

                EditorGUI.indentLevel--;

                GUILayout.EndVertical ();
            }
            else
            {

                GUILayout.BeginHorizontal ();

                EditorGUILayout.LabelField (label);
                EditorGUILayout.LabelField ("null", GUILayout.MinWidth (20));

                GUILayout.EndHorizontal ();
            }

            return obj;
        }
    }
}
