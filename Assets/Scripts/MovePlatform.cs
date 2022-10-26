using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] Points;
    private int CurrentPointIndex = 0;
    [SerializeField] private float MoveSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Points[CurrentPointIndex].transform.position) < .1f)
        {
            CurrentPointIndex = (CurrentPointIndex + 1) % Points.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, Points[CurrentPointIndex].transform.position,
            MoveSpeed * Time.deltaTime);
    }
}