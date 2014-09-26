using UnityEngine;
using System.Collections;

public class Spindle : MonoBehaviour {
    public float rpm = 100.0f / 3;

    float angle;

    public float Angle {
        get { return angle; }
    }

    void Update()
    {
        var delta = rpm * 6 * Time.deltaTime;

        angle = (angle + delta) % 360.0f;

        transform.localRotation = Quaternion.AngleAxis(angle, Vector3.up);
    }
}
