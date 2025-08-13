using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject molePrefab;
    [Header("自然存活时间")]
    public float aliveTime = 1;
    [Header("生成间隔")]
    public int intervalMin = 2;
    public int intervalMax = 10;

    void Start()
    {
        Invoke("Spawn" , Random.Range(intervalMin,intervalMax));
    }

    /// <summary>
    /// 生成地鼠
    /// </summary>
    void Spawn()
    {
        GameObject g = Instantiate(molePrefab , transform.position ,Quaternion.identity);
        //自然存活时间后死亡
        Destroy(g , aliveTime);

        //随机时间生成地鼠
        Invoke("Spawn" , Random.Range(intervalMin,intervalMax));
    }
}
