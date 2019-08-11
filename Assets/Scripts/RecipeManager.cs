using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    public static RecipeManager Instance;

    public enum IngredientType { Cheese, Bread, Leek, Sausage, Flour, Steak, Pistolet }
    [SerializeField] IngredientType[] ingredients = new IngredientType[3];
    public int MaxIngredients = 3;

    private int ingredientIndex = 0;

    public GameObject ParticlePrefab;

    public GameObject TostiPrefab;

    public GameObject BroodjevleesPrefab;


    private void Awake()
    {
        Instance = this;
    }

    public void AddIngredient(IngredientType _type)
    {
        ingredients[ingredientIndex] = _type;
        Debug.Log(ingredientIndex);
        ingredientIndex++;

        if (ingredientIndex >= MaxIngredients)
            CheckIngredients();
    }

    void CheckIngredients()
    {
        //Tosti
        if(ingredients[0] == IngredientType.Bread && ingredients[1] == IngredientType.Cheese && ingredients[2] == IngredientType.Bread)
        {
            CookedCorrectly(TostiPrefab);
        }
        //BroodjeVlees
        else if (ingredients[0] == IngredientType.Pistolet && ingredients[1] == IngredientType.Steak && ingredients[2] == IngredientType.Pistolet)
        {
            CookedCorrectly(BroodjevleesPrefab);
        }

        else
        {
            CookedWrong();
        }
    }

    void CookedCorrectly(GameObject _obj)
    {
        //Instantiate(_obj); //DIT IS ZONDER POSITIE EN ROTATIE
        Instantiate(_obj, _obj.transform.position, _obj.transform.rotation); //DIT IS MET PREFAB POSITIE EN PREFAB ROTATIE
        ingredientIndex = 0;
    }

    void CookedWrong()
    {
        Instantiate(ParticlePrefab);
        ingredientIndex = 0;
    }

    void ResetCook()
    {
        //reset ofzo
    }
}
