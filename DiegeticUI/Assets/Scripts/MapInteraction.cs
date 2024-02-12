using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapInteraction : MonoBehaviour
{
    public GameObject map;
    private Vector3 destination = new Vector3(0, 1.22f, -.156f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
            map.SetActive(!map.activeInHierarchy);
            //map.transform.position = (destination * Time.deltaTime);
        }
    }
}
