using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatBattery : MonoBehaviour
{
    public GameObject battery;

    private void OnTriggerEnter(Collider other)
    {
        ProgressBarCircle pb = ProgressCirlce.Pb.GetComponent<ProgressBarCircle>();
        if (other.gameObject.tag == "Player")
        {
            if (pb.BarValue < 100)
            {
                if (pb.BarValue >= 85)
                {
                    pb.BarValue = 100;
                }
                else
                {
                    pb.BarValue += 5;
                    pb.BarValue += 5;
                    pb.BarValue += 5;
                }
                Destroy(battery);
            }
        }

    }
}
