using UnityEngine;
using System.Collections.Generic;

public class Isla : MonoBehaviour
{
    // Attributes
    // public (properties)
    public List<Pirata> piratasEnLaIsla;
    public string nombreIsla;

    // private
    private bool _tesoroReclamado = false;
    private int _tesoroIsla = 120;

    // Methods
    public Pirata PelearPorElTesoro()
    {
        int mayorFuerza = 0;
        Pirata pirataGanador = null;
        foreach (Pirata pirata in piratasEnLaIsla)
        {
            if (pirata.GetFuerzaTotal() > mayorFuerza)
            {
                mayorFuerza = pirata.GetFuerzaTotal();
                pirataGanador = pirata;
            }
            pirata.armaEquipada.ReducirDurabilidad(1);
        }
        return pirataGanador;
    }

    public void AnunciarGanador(Pirata ganador)
    {
        print("¡El pirata más despiadado ha sido " + ganador.nombre + "! ¡Se ha llevado un botín de " + _tesoroIsla + " monedas de oro!");
        ganador.ReclamarBotin(_tesoroIsla);
        _tesoroReclamado = true;
    }

    public void Start()
    {
        if (!_tesoroReclamado)
        {
            print("En la lejana isla " + nombreIsla + " se encuentran los piratas...");
            foreach (Pirata pirata in piratasEnLaIsla)
            {
                if (pirata.armaEquipada != null)
                {
                    print(pirata.nombre + " portando el arma " + pirata.armaEquipada.nombre);
                }
                else
                {
                    print(pirata.nombre + " ...¿desarmado?");
                }
            }

            AnunciarGanador(PelearPorElTesoro());
        }
        else
        {
            print("Parece que el tesoro de esta isla ya ha sido reclamado. ¡Sigue navegando!");
        }
    }
}
