using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactible : MonoBehaviour
{
    public bool isInteractive;
    public bool isActive;
    public bool isPickable;
    public bool allowsPlacement;
    public bool allowsMultipleInteractions;
    public string requirementText;
    public string interactionText;
    public bool consumesRequirements;
    public Interactible[] inventoryRequirements;
    public Interactible[] indirectInteractibles;
    public Interactible[] indirectActivations;
    Collider m_Collider;
	
	public Player playerinstance;  
	
	
	public void Start()
	{
		playerinstance = GameObject.FindWithTag("Player").GetComponent<Player>();
		
		//GameObject.Find("espada").GetComponent<Renderer>().enabled = false;
		
	}

    public void Activate()
    {
        isActive = false;
        isInteractive = true;
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = true;

    }
    public void Deactivate()
    {
        isInteractive = false;
        isActive = false;
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = false;

    }

    public void Interact()
    {
		
		
      /*  if (isPuzzle2)
        {
            if (isInteractive)
            {
                PlayInteractAnimation();
                InteractIndirects();
            }
            else 
            {

                InteractIndirects();

                ActivateIndirects();

                PlayActivateAnimation();

                if (!allowsMultipleInteractions)
                    isInteractive = false;
            }
        }
		
        else
        {
            PlacePlaceables();

            PlayInteractAnimation();

            if (isActive)
            {

                InteractIndirects();

                ActivateIndirects();

                PlayActivateAnimation();

                if (!allowsMultipleInteractions)
                    isInteractive = false;
            }
        }*/
    }

    private void PlayActivateAnimation()
    {
        Animator animator = GetComponent<Animator>();

        if (animator != null)
            animator.SetTrigger("Activate");
    }

    private void PlayInteractAnimation()
    {

    }

    private void InteractIndirects()
    {

    }

    private void ActivateIndirects()
    {
        if (indirectActivations != null)
        {
            for (int i = 0; i < indirectActivations.Length; ++i)
                indirectActivations[i].Activate();
        }
    }

    private void PlacePlaceables()
    {
        if (allowsPlacement && isActive)
        {
            if (indirectInteractibles != null)
            {
                for (int i = 0; i < indirectInteractibles.Length; ++i)
                    indirectInteractibles[i].gameObject.SetActive(true);
            }
        }
    }

}