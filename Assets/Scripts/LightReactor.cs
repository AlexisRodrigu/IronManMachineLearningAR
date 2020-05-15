using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightReactor : MonoBehaviour
{[Header("Time")]
    public float duration = 1.0f;
    Color color0 =new Color32(65, 113,112,255);
    Color color1 = new Color32(68,202,199,255);
    Light lt;
    private void Start()
    {
       lt = GetComponent<Light>();
    }
    private void Update()
    {
        // set light color
        float t = Mathf.PingPong(Time.time, duration) / duration;
        lt.color = Color.Lerp(color0, color1, t);
    }
  


}
