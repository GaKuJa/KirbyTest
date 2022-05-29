using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class BaseChara : MonoBehaviour
{
    [SerializeField]
    protected int hp;

    [SerializeField]
    protected int atk;

    [SerializeField]
    protected int def;

    [SerializeField]
    protected float speed;

    [SerializeField]
    protected Material material;
}
