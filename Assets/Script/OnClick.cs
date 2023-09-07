using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    [SerializeField] private Text _count;
    [SerializeField] private int _countInt;
    [SerializeField] private List<Sprite> images;
    private int imagesCount;
    private Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
        imagesCount = 0;
    }
    public void Click()
    {
        _countInt = int.Parse(_count.text);
        _count.text = (_countInt + 1).ToString();

        imagesCount ++;
        if (imagesCount == images.Count) imagesCount = 0;
        _image.sprite = images[imagesCount];

    }
}
