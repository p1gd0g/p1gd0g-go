using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class NewBehaviourScript : MonoBehaviour
{

    public Text _text = null;
    public Image _img = null;

    // Start is called before the first frame update
    void Start()
    {
        _text.text = "I love zoe";
        _text.transform.DOJump(new Vector3(111, 111, 111), 3, 33, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello zoe");
    }
}
