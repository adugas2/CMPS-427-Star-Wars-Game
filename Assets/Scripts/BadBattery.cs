using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBattery : MonoBehaviour
{
    public GameObject battery;
    ProgressBarCircle pb = ProgressCirlce.Pb.GetComponent<ProgressBarCircle>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (pb.BarValue >= 0)
            {
                if (pb.BarValue < 5)
                {
                    pb.BarValue = 0;
                }
                else
                {
                    pb.BarValue -= 5;
                }
                Destroy(battery);
            }
        }

    }

}
