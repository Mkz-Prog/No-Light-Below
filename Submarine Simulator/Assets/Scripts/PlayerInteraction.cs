using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactDistance = 3f;
    [SerializeField] private KeyCode interactKey = KeyCode.E;
    [SerializeField] private LayerMask interactableLayer;

    private Camera playerCamera;

    private void Start()
    {
        playerCamera = Camera.main;
    }

    private void Update()
    {
        Ray ray = playerCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance, interactableLayer))
        {
            if (Input.GetKey(interactKey)) // Надо сделать обработку коротких нажатий и длинных отдельно
            {
                if (hit.collider.TryGetComponent(out InteractableObject interactable))
                {
                    interactable.Interact();
                }
            }
        }
    }
}