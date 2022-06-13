using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour
{
    /*private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;

    public bool analog;

    void Update () {
        if (analog) {
            TimeSpan timeSpan = DateTime.Now.TimeOfDay;
            hours.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalHours * -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalMinutes * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, (float)timeSpan.TotalSeconds * -secondsToDegrees);
        }
        else {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees);
        }
    }*/

    private const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime time = DateTime.Now;

        seconds.localRotation = Quaternion.Euler(time.Second * secondsToDegrees, 0f, 0f);

        TimeSpan timespan = DateTime.Now.TimeOfDay;
        hours.localRotation =
            Quaternion.Euler((float)timespan.TotalHours * hoursToDegrees, 0f, 0f);
        minutes.localRotation =
            Quaternion.Euler((float)timespan.TotalMinutes * minutesToDegrees, 0f, 0f);

    }
}
