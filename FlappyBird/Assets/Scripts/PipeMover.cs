using UnityEngine;

public class PipeMover : MonoBehaviour
{
     [SerializeField] Vector3 moveSpeed;
   
    // Update is called once per frame
    void Update()
    {
        // perque funcioni a tots els ordinadors igual , sense importar els fps que pot tenir cada un 
        transform.position +=  moveSpeed * Time.deltaTime;
        
    }
}
