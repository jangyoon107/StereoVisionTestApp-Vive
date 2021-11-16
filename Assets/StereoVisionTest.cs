using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StereoVisionTest : MonoBehaviour
{
    public GameObject QuadLeft, QuadRight;

    private Texture2D noise_1L, noise_1R, stereo_1L, stereo_1R, stereo_2L, stereo_2R, stereo_3L, stereo_3R;

    // Start is called before the first frame update
    void Start()
    {
        noise_1L = (Texture2D)Resources.Load("stereo_0L");
        noise_1R = (Texture2D)Resources.Load("stereo_0R");
        stereo_1L = (Texture2D)Resources.Load("stereo_1L");
        stereo_1R = (Texture2D)Resources.Load("stereo_1R");
        stereo_2L = (Texture2D)Resources.Load("stereo_2L");
        stereo_2R = (Texture2D)Resources.Load("stereo_2R");
        stereo_3L = (Texture2D)Resources.Load("stereo_3L");
        stereo_3R = (Texture2D)Resources.Load("stereo_3R");

        QuadLeft.GetComponent<Renderer>().material.mainTexture = noise_1L;
        QuadRight.GetComponent<Renderer>().material.mainTexture = noise_1R;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            QuadLeft.GetComponent<Renderer>().material.mainTexture = stereo_1L;
            QuadRight.GetComponent<Renderer>().material.mainTexture = stereo_1R;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            QuadLeft.GetComponent<Renderer>().material.mainTexture = stereo_2L;
            QuadRight.GetComponent<Renderer>().material.mainTexture = stereo_2R;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            QuadLeft.GetComponent<Renderer>().material.mainTexture = stereo_3L;
            QuadRight.GetComponent<Renderer>().material.mainTexture = stereo_3R;
        }
    }
}
