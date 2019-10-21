using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSetup : MonoBehaviour
{
    public string humanLor;
    public string elfsLor;
    public string orcsLor;
    public string gnomesLor;
    [Space]
    public string humanAbilities;
    public string elfsAbilities;
    public string orcsAbilities;
    public string gnomesAbilities;

    public void HumanLor()
    {
        if (humanLor.Length <=0 && humanAbilities.Length <=0)
        {
            TextAsset humanTextAsset = (TextAsset)Resources.Load("TextRU/HeroesLor/HumanLor");
            humanLor = humanTextAsset.text;

            TextAsset humanAbTextAsset = (TextAsset)Resources.Load("TextRU/HeroesAbilities/HumanAbilities");
            humanAbilities = humanAbTextAsset.text;
        }
    }

    public void ElfsLor()
    {
        if (elfsLor.Length <=0 && elfsAbilities.Length <=0)
        {
            TextAsset elfTextAsset = (TextAsset)Resources.Load("TextRU/HeroesLor/ElfsLor");
            elfsLor = elfTextAsset.text;

            TextAsset elfsAbTextAsset = (TextAsset)Resources.Load("TextRU/HeroesAbilities/ElfsAbilities");
            elfsAbilities = elfsAbTextAsset.text;
        }
    }

    public void OrcsLor()
    {
        if (orcsLor.Length <=0 && orcsAbilities.Length <=0)
        {
            TextAsset orcTextAsset = (TextAsset)Resources.Load("TextRU/HeroesLor/OrcsLor");
            orcsLor = orcTextAsset.text;

            TextAsset orcsAbTextAsset = (TextAsset)Resources.Load("TextRU/HeroesAbilities/OrcsAbilities");
            orcsAbilities = orcsAbTextAsset.text;
        }
    }

    public void GnomesLor()
    {
        if (gnomesLor.Length <=0 && gnomesAbilities.Length <=0)
        {
            TextAsset gnomeTextAsset = (TextAsset)Resources.Load("TextRU/HeroesLor/GnomesLor");
            gnomesLor = gnomeTextAsset.text;

            TextAsset gnomesAbTextAsset = (TextAsset)Resources.Load("TextRU/HeroesAbilities/GnomesAbilities");
            gnomesAbilities = gnomesAbTextAsset.text;
        }
    }
}
