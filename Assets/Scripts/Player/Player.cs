using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxInteractionDistance;
    public int   inventorySize;

    private RaycastHit          _raycastHit;
    private Interactible        _currentInteractible;
    public List<Interactible>  _inventory;
    public int itemsRequiredInInv;
	public bool Checkifcollided = false;

    private void Start()
    {
        _currentInteractible = null;

        _inventory = new List<Interactible>(inventorySize);
    }

    void Update()
    {
        CheckForInteractible();
        CheckForInteractionClick();
    }

    private void CheckForInteractible()
    {
       /* if (Physics.Raycast(_camera.transform.position,
            _camera.transform.forward, out _raycastHit,
            maxInteractionDistance))
        {
            Interactible newInteractible = _raycastHit.collider.GetComponent<Interactible>();

            if (newInteractible != null && newInteractible.isInteractive)
                SetInteractible(newInteractible);
            else
                ClearInteractible();
        }
        else
            ClearInteractible();*/
    }

    private void CheckForInteractionClick()
    {
       /* if (Input.GetKeyDown(KeyCode.F) && _currentInteractible != null)
        {

            if (_currentInteractible.isPickable)
            {
                _currentInteractible.Interact();
                AddToInventory(_currentInteractible);
            }
            else if (HasRequirements(_currentInteractible))
            {
                
                Interact(_currentInteractible);
            }
        }*/
		if(Checkifcollided == true && _currentInteractible != null)
		{
			if (_currentInteractible.isPickable)
            {
                _currentInteractible.Interact();
                AddToInventory(_currentInteractible);
				Debug.Log("Adicionar ao inventory");
            }
            else if (HasRequirements(_currentInteractible))
            {
                Debug.Log("Interagir");
                Interact(_currentInteractible);
            }
		}
    }

    private void SetInteractible(Interactible newInteractible)
    {
        _currentInteractible = newInteractible;
    }

    private void ClearInteractible()
    {
        _currentInteractible = null;
    }
    private bool HasAtLeastOneRequirement(Interactible interactible)
    {
        for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
            if (HasInInventory(interactible.inventoryRequirements[i]))
                return true;
        return false;
    }
    private bool HasLengthMinuesOne(Interactible interactible)
    {

        for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
            if (HasInInventory(interactible.inventoryRequirements[i]))
            {
                itemsRequiredInInv++;
                if( interactible.inventoryRequirements.Length - 1 == itemsRequiredInInv)
                return true;
            }
        return false;
    }
    private bool HasRequirements(Interactible interactible)
    {
        for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
            if (!HasInInventory(interactible.inventoryRequirements[i]))
                return false;

        return true;
    }

    private void Interact(Interactible interactible)
    {
        if (interactible.consumesRequirements)
        {
            /*for (int i = 0; i < interactible.inventoryRequirements.Length; ++i)
                RemoveFromInventory(interactible.inventoryRequirements[i]);

            if (_currentInteractible.State == 1)
            {
                heart.gameObject.SetActive(true);
                heart.isInteractive = false;
                AddToInventory(jewel);
            }
            else if (_currentInteractible.isPuzzle2)
                jewel.gameObject.SetActive(true);
*/
        }

        interactible.Interact();


    }

    public void AddToInventory(Interactible pickable)
    {
        if (_inventory.Count < inventorySize)
        {
            _inventory.Add(pickable);
            pickable.gameObject.SetActive(false);
            Debug.Log("Adds objects to inventory");
        }
    }

    public bool HasInInventory(Interactible pickable)
    {
        return _inventory.Contains(pickable);
    }

    private void RemoveFromInventory(Interactible pickable)
    {
        _inventory.Remove(pickable);
        Debug.Log("Uses the object");
    }
	
	private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "pickable")
		{
            Debug.Log("Pegou");
			Checkifcollided = true;

		}
    }

}