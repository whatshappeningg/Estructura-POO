using UnityEngine;

public class Pirata : MonoBehaviour
{
    // Attributes
    // public (properties)
    public string nombre;
    public int fuerzaBase;
    public Arma armaEquipada;

    // private
    private int _monedasDeOro;

    // Methods
    public void ReclamarBotin(int botin)
    {
        _monedasDeOro += botin;
    }
    public int GetFuerzaTotal()
    {
        if (armaEquipada == null)
        {
            return fuerzaBase;
        }
        else
        {
            return fuerzaBase + armaEquipada.daño;
        }
    }
    public void EquiparArma(Arma nuevaArma)
    {

    }


}
