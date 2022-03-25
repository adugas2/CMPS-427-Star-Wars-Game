using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressCirlce : MonoBehaviour
{
    public GameObject progressBar;
    public static ProgressBarCircle Pb;
    public int batteryDrainageSpeed = 2;


    void Start()
    {
        Pb = progressBar.GetComponent<ProgressBarCircle>();
        Pb.BarValue = 100;
    }
    // Update is called once per frame
    void Update()
    {
        if (Pb.BarValue <= 100 && Pb.BarValue > 0)
        {
            Pb.BarValue -= batteryDrainageSpeed * Time.deltaTime;
        }

        if (Pb.BarValue < 0)
        {
            Pb.BarValue = 0;
        }

        if (Pb.BarValue > 100)
        {
            Pb.BarValue = 100;
        }
    }
}
