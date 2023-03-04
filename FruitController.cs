using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject item;
    static int objects = 0;
    [SerializeField] TimeController time_script;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown(){
        objects++;
        Debug.Log(objects);
        gameObject.SetActive(false);
        item.SetActive(false);
        if(objects == 3){
            time_script.foundAllObjects = true;
        }

    }
}
