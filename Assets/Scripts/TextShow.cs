using UnityEngine;
using System.Collections;
using System;
public class Starting_line : MonoBehaviour
{

    bool crossedBoundary;
    int DelayTime = 0;
    int UnixTime()
    {
        return (int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            crossedBoundary = true;
        }
    }
    void OnGUI()
    {

        if (crossedBoundary == true)
        {
            GUI.Label(new Rect(650, 800, 600, 200), "Hello! I bet you're wondering what is going on here...hehe... but I can assure that you will understand everything in due time...");
            if (DelayTime == 0) { DelayTime = UnixTime() + 10; }
            if (DelayTime == UnixTime())
            {
                Destroy(gameObject);
            }
        }
    }

}