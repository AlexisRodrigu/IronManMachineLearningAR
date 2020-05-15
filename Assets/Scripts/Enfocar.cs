using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Enfocar : MonoBehaviour
{
   public void Enfoque(){
       CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
   }
}
