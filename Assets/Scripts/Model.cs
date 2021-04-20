using UnityEngine;

[CreateAssetMenu(fileName = "New model", menuName = "Assets/Model")]

public class Model : ScriptableObject {
    public string modelID;
    public string registrationNumer;
    public string modelName;
    public Mesh model;

}
