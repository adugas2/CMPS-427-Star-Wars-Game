using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorribleBattery : MonoBehaviour
{
    public GameObject battery;

    private void OnTriggerEnter(Collider other)
    {
        ProgressBarCircle pb = ProgressCirlce.Pb.GetComponent<ProgressBarCircle>();
        if (other.gameObject.tag == "Player")
        {
            if (pb.BarValue >= 0)
            {
                if (pb.BarValue < 15)
                {
                    pb.BarValue = 0;
                }
                else
                {
                    pb.BarValue -= 5;
                    pb.BarValue -= 5;
                    pb.BarValue -= 5;
                }
                Destroy(battery);
            }
        }

    }
}
