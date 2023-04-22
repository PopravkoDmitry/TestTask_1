using UnityEngine;

[CreateAssetMenu(fileName = "Mashes", menuName = "ScriptableObjects/Mashes")]
public class Mashes : ScriptableObject
{
    [SerializeField] private Mesh cubeMesh;
    [SerializeField] private Mesh sphereMesh;
    [SerializeField] private Mesh cylinderMesh;
    
    public Mesh CubeMesh => cubeMesh;
    public Mesh SphereMesh => sphereMesh;
    public Mesh CylinderMesh => cylinderMesh;
}
