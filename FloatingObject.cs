using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///[RequireComponent(typeof(Rigidbody))]


public class FloatingObject : MonoBehaviour
{
    public Transform[] floaters;


    public float underWaterDrag = 3f;
    public float underWaterAngularDrag = 1f;
    public float airDrag = 0f;
    public float airAngularDrag = 0.05f;
    public float floatingPower = 15f;

    OceanManager oceanManager;

    private Rigidbody thisRigidbody;

    int floatersUnderWater;


    bool underwater;
    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
        oceanManager = FindObjectOfType<OceanManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        floatersUnderWater = 0;
        for (int i = 0; i < floaters.Length; i++)
        {
           // float difference = floaters[i].position.y - 0f;
              float difference = floaters[i].position.y - oceanManager.WaterHeightAtPosition(floaters[i].position);
          //  print(i + ":" + oceanManager.WaterHeightAtPosition(floaters[i].position));
            if (difference < 0)
            {
                thisRigidbody.AddForceAtPosition(Vector3.up * floatingPower * Mathf.Abs(difference), floaters[i].position, ForceMode.Force);
                floatersUnderWater += 1;
                if (!underwater)
                {
                    underwater = true;
                    SwitchState(true);
                }
            }

            else if (underwater && floatersUnderWater == 0)
            {
                underwater = false;
                SwitchState(false);
            }

        }
        void SwitchState(bool isUnderwater)
        {
            if (isUnderwater)
            {
                thisRigidbody.drag = underWaterDrag;
                thisRigidbody.angularDrag = underWaterAngularDrag;
            }
            else
            {
                thisRigidbody.drag = airDrag;
                thisRigidbody.angularDrag = airAngularDrag;
            }
        }
    }

}
