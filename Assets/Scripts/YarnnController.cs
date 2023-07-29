using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine.UI;

public class YarnnController : MonoBehaviour
{
    public GameObject NPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] SerializableDictionaryBase<string, Sprite> DictionaryExpression = default;
    [YarnCommand("SetNPC")]
    public void SetMaterial(string id)
    {
        if (DictionaryExpression.ContainsKey(id))
            NPC.GetComponent<Image>().sprite = DictionaryExpression[id];
    }

    [YarnCommand("ShowNPC")]
    public void ShowNpc()
    {
        NPC.SetActive(true);
    }


    [YarnCommand("HideNPC")]
    public void HideNpc()
    {
        NPC.SetActive(false);
    }
}
