using UnityEngine;

public class player : MonoBehaviour
{
    
    /*
    */
    #region 角色
    public float speed;
    public float hp;
    public float hight;
    public int coin;
    public bool dead;
    public AudioClip CMusic;
    public AudioClip JMusic;
    public AudioClip SMusic;
    #endregion

    # region 方法
    /// <summary>
    /// 
    /// </summary>
    private void Jump()
    {
        print("跳躍");
    }
    /// <summary>
    /// 
    /// </summary>
    private void Hit()
    {
        print("碰撞");
    }
    /// <summary>
    /// 
    /// </summary>
    private void Dead()
    {

    }
    /// <summary>

    /// 
    /// </summary>
    private void Coin()
    {

    }
    /// <summary>
    /// 
    /// </summary>
    private void Slide()
    {

    }
    #endregion
    #region 事件
    private void Start()
    {
        Hit();   
    }
    private void Update()
    {
        Jump();
    }
    #endregion

    //
}
