using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerStatus : MonoBehaviour
{
    public GameObject model1;
    public GameObject model2;
    public GameObject currentModel;

    void Awake()
    {
        currentModel = Instantiate(model1, transform.position, transform.rotation) as GameObject;
        currentModel.transform.parent = transform;
        currentModel.transform.eulerAngles = new Vector3(0, 90, 0);
        currentModel.tag = "Player";
    }

    public void ChangeModel()
    {
        if (currentModel == model1)
        {
            GameObject thisModel = Instantiate(model2, transform.position, transform.rotation) as GameObject;
            Destroy(currentModel);
            thisModel.transform.parent = transform;
            currentModel = thisModel;
        }
        else
     {
            GameObject thisModel = Instantiate(model1, transform.position, transform.rotation) as GameObject;
            Destroy(currentModel);
            thisModel.transform.parent = transform;
            currentModel = thisModel;
        }
    }


}
