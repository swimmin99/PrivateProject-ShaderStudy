using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OceanManager : MonoBehaviour
{

    public float WaveHeight = 10f;
    public float WaveFrequency = 0.16f;
    public float WaveSpeed = 0.36f;
    public float PlayerMovingSpeed = 0.25f;
    public Transform ocean;
    public GameObject oceanObj;
    public TextMeshProUGUI text;

    Material oceanMat;
    Texture2D displacementWaves;
    // Start is called before the first frame update
    void Start()
    {
        text.SetText("BasicValue OC");
        oceanMat = ocean.GetComponent<Renderer>().sharedMaterial;
        displacementWaves = (Texture2D)oceanMat.GetTexture("_WavesDisplacement");
    }

    // Update is called once per frame
    public float WaterHeightAtPosition(Vector3 position)
    {
        text.SetText("startedGettingPositionOM");

        //return ocean.position.y + displacementWaves.GetPixelBilinear(position.x * (WaveFrequency/100) * ocean.localScale.x, (position.z * (WaveFrequency/100) + Time.time * (WaveSpeed/100)) * ocean.localScale.z).g* WaveHeight;
        // return ocean.position.y + displacementWaves.GetPixelBilinear(position.x * WaveFrequency * ocean.localScale.x, (position.z * WaveFrequency + Time.time * WaveSpeed) * ocean.localScale.z).g * (WaveHeight);
        return ocean.position.y + displacementWaves.GetPixelBilinear(position.x * WaveFrequency, position.z * WaveFrequency + Time.deltaTime * WaveSpeed).g * (WaveHeight);
    }
    
}
   