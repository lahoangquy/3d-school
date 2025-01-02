using UnityEngine;

public class GraduationCapThrow : MonoBehaviour
{
    [Tooltip("Starting position for the throw (character's hand)")]
    [SerializeField] private Transform throwStartPoint; 
    
    [Tooltip("Prefab of the cap")]
    [SerializeField] private GameObject capPrefab;      
    
    [Tooltip("Throwing force of the cap")]
    [SerializeField] private float throwForce = 10f;    
    
    [Tooltip("Time before the cap returns")]
    [SerializeField] private float returnDelay = 3f;    

    private GameObject _currentCap;             
    
    private Rigidbody _capRigidbody;            
    
    private bool isThrown = false;   

    // gắn sẵn prefab mũ trong cánh tay người chơi           
   
    private void SpawnCap()
    {
        // Create the cap at the starting position
        _currentCap = Instantiate(capPrefab, throwStartPoint.position, throwStartPoint.rotation);
        _capRigidbody = _currentCap.GetComponent<Rigidbody>();

        // Ensure the cap is held fixed at the character's hand before throwing
        _capRigidbody.isKinematic = true;
        _currentCap.transform.parent = throwStartPoint;
    }

    public void ThrowCap()
    {
        SpawnCap();
        // Release the cap and apply throwing force
        isThrown = true;
        _currentCap.transform.parent = null;
        _capRigidbody.isKinematic = false;
        _capRigidbody.AddForce(Vector3.up * throwForce + transform.forward * (throwForce / 2), ForceMode.Impulse);

        // Call the function to return the cap after a delay
        Invoke(nameof(ReturnCap), returnDelay);
    }

    private void ReturnCap()
    {
        // Return the cap to the character's hand
        isThrown = false;
        _currentCap.transform.position = throwStartPoint.position;
        _currentCap.transform.rotation = throwStartPoint.rotation;
        _capRigidbody.isKinematic = true;
        _currentCap.transform.parent = throwStartPoint;
    }
}
