using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    List<GameObject> unityGameObjects = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("pickable");

        if (collision.gameObject.tag == "pickable") {
            Debug.Log("Pegou");
            foreach (GameObject go in gameObjectArray) {
                go.SetActive(false);
                unityGameObjects.Add(go);
                //Destroy(go);
            }
        }
       /* if (collision.gameObject.tag == "pickable") {
            Debug.Log("Pegou pickable");
           // pickable1 = true;
           // pickable1object.transform.SetParent(Playerparent.transform);
        }*/
    }
}
