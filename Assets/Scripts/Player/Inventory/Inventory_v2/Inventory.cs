using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    bool haveObject = false;
    MeshRenderer holding;

    [SerializeField]
    private GameObject empty;

    Rigidbody2D prefab;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "pickable" && haveObject == false)
        {
            ThrowUpdate(col.GetComponent<Material>());
            Destroy(col.gameObject);
        }
    }

    private void ThrowUpdate(Material temp)
    {
        holding.material = temp;
        haveObject = true;

    }

    private void Throw()
    {
        if(Input.GetMouseButtonDown(1) && haveObject == true)
        {
            Instantiate(prefab, transform.position, transform.rotation);
            haveObject = false;
        }  
    }
}
