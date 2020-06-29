using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrUnitAffinities : MonoBehaviour
{
    // Variable declaration section

    public float[] UnitElementalAffinityNature;
    public float[] UnitElementalAffinityIntensity;

    public List<float> listUnitOriginalElementalAffinities;
    public List<float> listUnitCurrentElementalAffinities;

    public float[] UnitAilmentAffinityNature;
    public float[] UnitAilmentAffinityIntensity;

    public List<float> listUnitOriginalAilmentAffinities;
    public List<float> listUnitCurrentAilmentAffinities;
    


    // Methods for unit self-maintenance, to prevent game rules from being broken and updating its own status.
    void ElementalListValuesTest()
    {
        for (int count = 0; count < 10; count++)
        {
            listUnitOriginalElementalAffinities.Add(UnitElementalAffinityIntensity[count]);
        }
        Debug.Log(listUnitOriginalElementalAffinities.ToString());
    }

    void UpdateElementalListValuesTest(int index, int newAffinity)
    {
        Debug.Log(index + ", " + newAffinity);
        listUnitOriginalElementalAffinities.RemoveAt(index);
        listUnitOriginalElementalAffinities.Insert(index, newAffinity);
        Debug.Log(listUnitOriginalElementalAffinities.ToString());
    }

    void StoreElementalListValuesTest()
    {
        for (int count = 0; count < 10; count++)
        {
            listUnitOriginalElementalAffinities.Add(UnitElementalAffinityIntensity[count]);
        }
        Debug.Log(listUnitOriginalElementalAffinities.ToString());
    }


    // Start is called before the first frame update
    void Start()
    {
        ElementalListValuesTest();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ElementalListValuesTest();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            UpdateElementalListValuesTest(Random.Range(0, 10), Random.Range(-1, 4));
        }
    }
}
