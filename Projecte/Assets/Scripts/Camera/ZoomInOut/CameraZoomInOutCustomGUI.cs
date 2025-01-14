﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[CustomEditor(typeof(CameraZoomInOut))]
public class CameraZoomInOutCustomGUI : Editor
{
   
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CameraZoomInOut myCameraZoomInOut = (CameraZoomInOut)target;

        if(myCameraZoomInOut.zoomX == true && myCameraZoomInOut.zoomY == true)
        {
            EditorGUILayout.HelpBox("No puedes seleccionar zoomX y zoomY a la vez", MessageType.Error,true);
        }
    }   

}
#endif
