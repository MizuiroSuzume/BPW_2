using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredient : MonoBehaviour
{
    public RecipeManager.IngredientType typeOfIngredient;

    public void InPan()
    {
        RecipeManager.Instance.AddIngredient(typeOfIngredient);
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider other)
    {   
        //VERANDER NAAR TAG == "Pan"   en geef de pan collider de tag "Pan"
        if(other.tag == "Pan")
        {
            InPan();
        }
    }
}
