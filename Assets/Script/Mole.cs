using UnityEngine;
using DG.Tweening;

public class Mole : MonoBehaviour
{
    //被击中时特效
    public GameObject onHitFX;
    public Texture2D mouseDownCursor;

    /// <summary>
    /// 击中地鼠时
    /// </summary>
    void OnMouseDown()
    {
        //隐藏Mole
        gameObject.SetActive(false);
        //屏幕震动
        Camera.main.transform.DOShakePosition(.2f,new Vector3(1,1,0));

        //切换成地鼠受伤时的Sprite
        GameObject g = Instantiate(onHitFX , transform.position , Quaternion.identity);
        Destroy(g , 0.2f);
    }
}
