using UnityEngine;

public class Arma : MonoBehaviour
{
    // Attributes
    // public (properties)
    public string nombre;
    public int daño;

    // private
    private float _durabilidad = 5;


    // Methods
    public void ReducirDurabilidad(float cantidad)
    {
        _durabilidad -= cantidad;
    }
}
