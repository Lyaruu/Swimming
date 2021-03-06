﻿using UnityEngine;
using System.Collections;

public class Fog : MonoBehaviour
{
    //This script enables underwater effects. Attach to main camera.

    //Define variable
    public int underwaterLevel = 7;

    //The scene's default fog settings
    private bool defaultFog = RenderSettings.fog;
    private Color defaultFogColor = RenderSettings.fogColor;
    private float defaultFogDensity;
    private Material defaultSkybox = RenderSettings.skybox;
    private Material noSkybox;
    public float fogDensity;
    new Camera camera;

    //void Start()
    //{
    //    //Set the background color
    //    camera.backgroundColor = new Color(0, 0.4f, 0.7f, 1);
    //}

    void Update()
    {
        if (transform.position.y < underwaterLevel)
        {
            RenderSettings.fog = true;
            RenderSettings.fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
            RenderSettings.fogDensity = fogDensity;
            RenderSettings.skybox = noSkybox;
        }
        else
        {
            RenderSettings.fog = defaultFog;
            RenderSettings.fogColor = defaultFogColor;
            RenderSettings.fogDensity = defaultFogDensity;
            RenderSettings.skybox = defaultSkybox;
        }
    }
}
