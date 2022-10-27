using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float AmplitudeX;
    [SerializeField] private float SpeedX;
    [SerializeField] private float AmplitudeY;
    [SerializeField] private float SpeedY;
    [SerializeField] private float AmplitudeZ;
    [SerializeField] private float SpeedZ;
    // Update is called once per frame
    private float DirectionX = 1f;
    private float DirectionY = 1f;
    private float DirectionZ = 1f;
    void Update()
    {
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        float limitX = AmplitudeX % 90;
        float limitY = AmplitudeY % 90;
        float limitZ = AmplitudeZ % 90;
        if (currentRotation.x > limitX && currentRotation.x < 180)
        {
            DirectionX = -1f;
        } else if (currentRotation.x > 180 && currentRotation.x < 360 - limitX)
        {
            DirectionX = 1f;
        }
        if (currentRotation.y > limitY && currentRotation.y < 180)
        {
            DirectionY = -1f;
        } else if (currentRotation.y > 180 && currentRotation.y < 360 - limitY)
        {
            DirectionY = 1f;
        }
        if (currentRotation.z > limitZ && currentRotation.z < 180)
        {
            DirectionZ = -1f;
        } else if (currentRotation.z > 180 && currentRotation.z < 360 - limitZ)
        {
            DirectionZ = 1f;
        }
        float RotationX = DirectionX * SpeedX * Time.deltaTime * 90;
        float RotationY = DirectionY * SpeedY * Time.deltaTime * 90;
        float RotationZ = DirectionZ * SpeedZ * Time.deltaTime * 90;
        transform.Rotate(RotationX, RotationY, RotationZ);
    }
}
