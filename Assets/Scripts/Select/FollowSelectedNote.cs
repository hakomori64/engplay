using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class FollowSelectedNote : MonoBehaviour
{

    [SerializeField]
    private ScrollRect _scrollRect;

    [SerializeField]
    private RectTransform _viewportRectransform;

    [SerializeField]
    private RectTransform _ndoePrefab;

    [SerializeField]
    private VerticalLayoutGroup _verticalLayoutGroup;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scroll() {
        Debug.Log("Hello");
    }
}
