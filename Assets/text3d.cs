using UnityEngine;

using System.Collections;

public class text3d : MonoBehaviour {
    TextMesh text;

    float startTime;
    int empathyScore;

    // Use this for initialization
    void Start () {
        text= gameObject.GetComponent("TextMesh") as TextMesh;

        startTime = Time.time;
    }

    // Update is called once per frame
    void Update () {
        empathyScore = (int)(Time.time - startTime);

        text.text = "Empathy Score: " + empathyScore.ToString();
    }
}
