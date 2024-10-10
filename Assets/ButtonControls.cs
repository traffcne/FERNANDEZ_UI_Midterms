using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ButtonControls : MonoBehaviour
{
    [SerializeField] public GameObject Slime;
    [SerializeField] public SpriteRenderer SlimeRenderer;
    [SerializeField] public Vector3 enlargeSize = new Vector3(1.5f,1.5f,1.5f);
    [SerializeField] public Vector3 shrinkSize = new Vector3(1f, 1f, 1f);
    [SerializeField] public Vector3 Flip = new Vector3(0f, -180f, 0f);
    [SerializeField] public Vector3 Swing = new Vector3(0f, -90, 0f);
    [SerializeField] public Vector3 Punch = new Vector3(0.3f, 0.3f, 0.3f);
    public void ScaleSlime()
    {
        Slime.transform.DOScale(enlargeSize, 2).OnComplete(()=>Slime.transform.DOScale(shrinkSize,1));
    }

    public void FadeSlime()
    {
        SlimeRenderer.DOFade(0, 1f);
    }
    public void ReturnSlime()
    {
        SlimeRenderer.DOFade(100, 1f);
    }

    public void FlipSlime()
    {
        Slime.transform.DORotate(Flip, 1f, RotateMode.Fast).OnComplete(() => Slime.transform.DORotate(new Vector3(0f,0f,0f), 1f, RotateMode.FastBeyond360));
    } 

    public void ZoomSlime()
    {
        Slime.transform.DOMoveX(1000f, 0.3f).OnComplete(() => Slime.transform.DOMoveX(5f, 0.3f));
    }

    public void SwingSlime()
    {
        Slime.transform.DORotate(Swing, 1f, RotateMode.Fast).OnComplete(() => Slime.transform.DORotate(new Vector3(0f, 0f, 0f), 0.7f, RotateMode.FastBeyond360));
    }

    public void JiggleSlime()
    {
        Slime.transform.DOPunchScale(Punch, 0.5f, 10, 5);
    }
}
