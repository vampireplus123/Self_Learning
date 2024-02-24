using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class RotateWithMatrices : MonoBehaviour
{
    public float angleX = 0;
    public float angleY = 0;
    public float angleZ = 0;

    Matrix4x4 RotateX;
    Matrix4x4 RotateY;
    Matrix4x4 RotateZ;

    public void Reset()
    {
        this.transform.rotation = Quaternion.identity;
    }

    public void RotateAroundX()
    {
        float aX = Mathf.Deg2Rad * angleX;
        RotateX = new Matrix4x4
        {
            m00 = 1,
            m01 = 0,
            m02 = 0,
            m03 = 0,
            m10 = 0,
            m11 = Mathf.Cos(aX),
            m12 = -Mathf.Sin(aX),
            m13 = 0,
            m20 = 0,
            m21 = Mathf.Sin(aX),
            m22 = Mathf.Cos(aX),
            m23 = 0,
            m30 = 0,
            m31 = 0,
            m32 = 0,
            m33 = 1
        };
        this.transform.forward = RotateX.MultiplyVector(this.transform.forward);
    }

    public void RotateAroundY()
    {
        float aY = Mathf.Deg2Rad * angleY;
        RotateY = new Matrix4x4
        {
            m00 = Mathf.Cos(aY),
            m01 = 0,
            m02 = Mathf.Sin(aY),
            m03 = 0,

            m10 = 0,
            m11 = 1,
            m12 = 0,
            m13 = 0,

            m20 = -Mathf.Sin(aY),
            m21 = 0,
            m22 = Mathf.Cos(aY),
            m23 = 0,

            m30 = 0,
            m31 = 0,
            m32 = 0,
            m33 = 1
        };
        this.transform.forward = RotateY.MultiplyVector(this.transform.forward);

    }

    public void RotateAroundZ()
    {
        float aZ = Mathf.Deg2Rad * angleZ;
        RotateZ = new Matrix4x4
        {
            m00 = Mathf.Cos(aZ),
            m01 = -Mathf.Sin(aZ),
            m02 = 0,
            m03 = 0,

            m10 = Mathf.Sin(aZ),
            m11 = Mathf.Cos(aZ),
            m12 = 0,
            m13 = 0,

            m20 = 0,
            m21 = 0,
            m22 = 1,
            m23 = 0,

            m30 = 0,
            m31 = 0,
            m32 = 0,
            m33 = 1
        };
        this.transform.forward = RotateZ.MultiplyVector(this.transform.forward);


    }

    public void RotateAroundXQ()
    {

    }
    public void RotateAroundYQ()
    {

    }
    public void RotateAroundZQ()
    {

    }
}
